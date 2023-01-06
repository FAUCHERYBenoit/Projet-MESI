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


        void Awake()
        {
            mouvementService = GetComponent<MouvementService>();
        }

        public void MovePlayer(Vector2 direction)
        {
            mouvementService.moveCharacter(direction);
        }

        public void Dash(Vector2 direction)
        {
            mouvementService.Dash(direction);
        }
    }

    
}

