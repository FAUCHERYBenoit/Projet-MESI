using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using messages;
using System;
using combat;
using combat.weapon;

namespace character
{
    public class PlayerManager : AbstractCharacterManager
    {
        public PlayerStats playerStats;

        [SerializeField] AnimatorManager animator;
        [SerializeField] CrossAir crossAir;

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
        }

        #region motion
        public void MovePlayer(Vector2 direction)
        {
            mouvementService.moveCharacter(direction);
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
            playerStats.AddOrRemoveStat(StatTypes.Life, damage.DamageAmount);
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

