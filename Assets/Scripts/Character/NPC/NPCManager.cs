using character.stat;
using combat;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace character
{
    public class NPCManager : AbstractCharacterManager
    {
        [SerializeField] NPCStats nPCStats;

        [SerializeField] ZombiTakeDamageCollider zombiTakeDamageCollider;
        [SerializeField] AnimatorManager animator;

        [SerializeField] StatSystem statSystem;

        private void Awake()
        {
            zombiTakeDamageCollider.onTakeDamage.AddListener(data => { TakeDamage(data); });
            statSystem = new StatSystem(nPCStats.characterStats);
        }

        protected override void TakeDamage(DamageData damage)
        {
            statSystem.AddOrRemoveStat(StatTypes.Life, damage.DamageAmount);

            Debug.Log("NPC has taken somedamage "+ damage.DamageAmount);

            if(statSystem.GetStatValue(StatTypes.Life) <= 0)
            {
                animator.PlayTargetAnimation("Z_01_Dead");
                Debug.Log($"<color=green>Dead</color>");
            }
        }
    }
}

