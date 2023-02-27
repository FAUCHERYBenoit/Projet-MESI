using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using messages;
using System;
using combat;
using combat.weapon;
using UnityEngine.InputSystem;
using character.stat;

namespace character
{
    public class PlayerManager : AbstractCharacterManager
    {
        [SerializeField] PlayerStats playerStats;

        [SerializeField] AnimatorManager animator;
        [SerializeField] CrossAir crossAir;
        [SerializeField] InputManager inputManager;
        [SerializeField] StatSystem statSystem;
        [SerializeField] Camera camera;

        [Header("colliders")]
        [SerializeField] PlayerTakeDamageCollider playerTakeDamageCollider;

        [Header("Mouvement")]
        [SerializeField] MouvementService mouvementService;
        [SerializeField] TrailRenderer dashTrail;

        [Header("combat")]
        [SerializeField] WeaponManager weaponManager;

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
        }
        #endregion

        protected override void TakeDamage(DamageData damage)
        {
            statSystem.AddOrRemoveStat(StatTypes.Life, damage.DamageAmount);
            Debug.Log("The player took damage");
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
                dashTrail.enabled = true;
            }
            else
            {
                animator.StopSpecialMotion();
                playerTakeDamageCollider.OpenCollider();
                dashTrail.enabled = false;
            }
        }
    }  
}

