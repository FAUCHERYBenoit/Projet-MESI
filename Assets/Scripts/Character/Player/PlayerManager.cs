using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using messages;
using System;

namespace character
{
    public class PlayerManager : AbstractCharacterManager
    {
        public PlayerStats playerStats;
        public MouvementService mouvementService;
        [SerializeField] AnimatorManager animator;
        [SerializeField] CrossAir crossAir;

        void Awake()
        {
            mouvementService = GetComponent<MouvementService>();
            if (crossAir == null)
            {
                crossAir = GetComponent<CrossAir>();
            }

            crossAir.CrossAirPositionChanged.AddListener(t => { RotatePlayer(t); });
        }

        private void Start()
        {
            mouvementService.onWalk.AddListener(() => { animator.StartRunning(); });
            mouvementService.onStop.AddListener(() => { animator.StopRunnning(); });
            mouvementService.onDashStart.AddListener(() => { animator.SpecialMovement(); });
            mouvementService.onDashStop.AddListener(() => { animator.StopSpecialMotion(); });
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
    }  
}

