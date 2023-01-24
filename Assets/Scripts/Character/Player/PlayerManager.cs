using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using messages;

namespace character
{
    public class PlayerManager : AbstractCharacterManager
    {
        public PlayerStats playerStats;
        public MouvementService mouvementService;
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
    }  
}

