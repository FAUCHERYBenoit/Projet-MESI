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
            zombiTakeDamageCollider.onTakeDamage.AddListener(data => { TakeDamage(data); });
        }

        protected override void TakeDamage(DamageData damage)
        {
            nPCStats.AddOrRemoveStat(StatTypes.Life, damage.DamageAmount);
            Debug.Log("NPC has taken somedamage "+ damage.DamageAmount);

            if( nPCStats.GetStatValue(StatTypes.Life) <= 0)
            {
                Debug.Log($"<color=green>Dead</color>");
            }
        }
    }
}

