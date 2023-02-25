using combat;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace character
{
    public class NPCManager : AbstractCharacterManager
    {
        public NPCStats nPCStats;

        [SerializeField] ZombiTakeDamageCollider zombiTakeDamageCollider;

        private void Awake()
        {
            zombiTakeDamageCollider.onTakeDamage.AddListener(data =>
            {

            });
        }

        protected override void TakeDamage(DamageData damage)
        {
            nPCStats.AddOrRemoveStat(StatTypes.Life, damage.damageAmount);
            Debug.Log("NPC has taken somedamage "+ damage.damageAmount);
        }
    }
}

