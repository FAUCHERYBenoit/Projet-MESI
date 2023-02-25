using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using messages;
using System;
using combat;

namespace character
{
    public class PlayerManager : AbstractCharacterManager
    {
        public PlayerStats playerStats;
        [SerializeField] MouvementService mouvementService;
        [SerializeField] AnimatorManager animator;
        [SerializeField] CrossAir crossAir;

        [SerializeField] PlayerTakeDamageCollider playerTakeDamageCollider;

        void Awake()
        {
            mouvementService = GetComponent<MouvementService>();
            if (crossAir == null)
            {
                crossAir = GetComponent<CrossAir>();
            }
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

        internal void Stop()
        {
            mouvementService.Stop();
        }

        protected override void TakeDamage(DamageData damage)
        {
            playerStats.AddOrRemoveStat(StatTypes.Life, damage.damageAmount);
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
            }
            else
            {
                animator.StopSpecialMotion();
                playerTakeDamageCollider.OpenCollider();
            }
        }
    }  
}

