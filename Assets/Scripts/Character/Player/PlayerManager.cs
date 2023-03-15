using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using messages;
using System;
using combat;
using combat.weapon;
using UnityEngine.InputSystem;
using character.stat;
using camera;

namespace character
{
    public class PlayerManager : AbstractCharacterManager
    {
        [SerializeField] PlayerStats playerStats;

        [SerializeField] AnimatorManager animator;
        [SerializeField] CrossAir crossAir;
        [SerializeField] InputManager inputManager;
        [SerializeField] StatSystem statSystem;

        [Header("Camera")]
        [SerializeField] Camera camera;
        [SerializeField] CameraShake cameraShake;

        [Header("colliders")]
        [SerializeField] PlayerTakeDamageCollider playerTakeDamageCollider;

        [Header("Mouvement")]
        [SerializeField] MouvementService mouvementService;
        [SerializeField] TrailRenderer dashTrail;

        [Header("combat")]
        [SerializeField] WeaponManager weaponManager;

        [SerializeField] bool canTakeDamage;

        Coroutine autoShootCorroutine;

        float currentFireRate;

        void Awake()
        {
            mouvementService = GetComponent<MouvementService>();
            if (crossAir == null)
            {
                crossAir = GetComponent<CrossAir>();
            }
            dashTrail.enabled = false;
            statSystem = new StatSystem(playerStats.characterStats);

            crossAir.Init(camera);
        }

        private void Start()
        {
            InitEvents();
        }

        private void InitEvents()
        {
            crossAir.CrossAirPositionChanged.AddListener(t => { RotatePlayer(t); });
            playerTakeDamageCollider.onTakeDamage.AddListener(data => { TakeDamage(data); });

            mouvementService.onWalk.AddListener(() => { animator.StartRunning(); });
            mouvementService.onStop.AddListener(() => { animator.StopRunnning(); });
            mouvementService.onDashStart.AddListener(() => { Handledash(true); });
            mouvementService.onDashStop.AddListener(() => { Handledash(false); });

            inputManager.onMove.AddListener(direction => MovePlayer(direction));
            inputManager.onDashAction.AddListener(direction => Dash(direction));
            inputManager.onPrimaryAction.AddListener(() => Shoot());
            inputManager.onRealeasePrimary.AddListener(() => ToggleOnOffAutoShoot(false));
            inputManager.onHoldPrimary.AddListener(() => ToggleOnOffAutoShoot(true));

            weaponManager.onFireRateChanged += (f) => currentFireRate = f; 

        }

        #region motion
        private void MovePlayer(Vector2 direction)
        {
            if (direction.x != 0 || direction.y != 0)
            {
                mouvementService.moveCharacter(direction);
            }
            else
            {
                Stop();
            }
        }

        public void Dash(Vector2 direction)
        {
            mouvementService.Dash(direction);
        }

        public void RotatePlayer(Transform transform)
        {
            mouvementService.RotatePlayer(transform);
        }

        public void Stop()
        {
            mouvementService.Stop();
        }
        #endregion
        #region Attack
        public void Shoot()
        {
            weaponManager.ShootBullet();
            cameraShake.ShakeCamera(1.25f, 0.2f, 1);
        }

        public void ToggleOnOffAutoShoot(bool isOn)
        {
            if (isOn)
            {
                autoShootCorroutine = StartCoroutine(AutoShoot());
            }
            else
            {
                if (autoShootCorroutine != null)
                {
                    StopCoroutine(autoShootCorroutine);
                }
            }
        }

        IEnumerator AutoShoot()
        {
            while (true)
            {
                yield return new WaitForSeconds(currentFireRate);
                Shoot();
            }
        }
        #endregion

        protected override void TakeDamage(DamageData damage)
        {
            if (canTakeDamage)
            {
                statSystem.AddOrRemoveStat(StatTypes.Life, damage.DamageAmount);
                cameraShake.ShakeCamera(2f, 0.1f, 1);
                Debug.Log($"<color=purple> The player took damage {statSystem.GetStatValue(StatTypes.Life)} </color>");
            }
        }

        /// <summary>
        /// Tooglles on the dash animation and the invulnerability frames
        /// </summary>
        /// <param name="isDashing"></param>
        private void Handledash(bool isDashing)
        {
            if (isDashing)
            {
                animator.SpecialMovement();
                playerTakeDamageCollider.CloseCollider();
                if (dashTrail != null)
                {
                    dashTrail.enabled = true;
                    canTakeDamage = false;
                }
            }
            else
            {
                animator.StopSpecialMotion();
                playerTakeDamageCollider.OpenCollider();
                if (dashTrail != null)
                {
                    dashTrail.enabled = false;
                    canTakeDamage = true;
                }
            }
        }
    }  
}

