using character.ai;
using character.stat;
using combat;
using System;
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
        [SerializeField] NPCBrain brain;

        [SerializeField] StatSystem statSystem;

        private void Awake()
        {
            zombiTakeDamageCollider.onTakeDamage.AddListener(data => { TakeDamage(data); });
            brain.onAnimationPlayed.AddListener((s, b, a) => HandleAnimationEvent(s, b, a));
            statSystem = new StatSystem(nPCStats.characterStats);
        }

        protected override void TakeDamage(DamageData damage)
        {
            statSystem.AddOrRemoveStat(StatTypes.Life, damage.DamageAmount);

            Debug.Log("NPC has taken somedamage "+ damage.DamageAmount);

            if(statSystem.GetStatValue(StatTypes.Life) <= 0)
            {
                brain.HandleState(AI_States.Dying);
                Debug.Log($"<color=green>Dead</color>");
            }
        }

        private void HandleAnimationEvent(string s, bool b, Action a)
        {
            animator.PlayTargetAnimation(s);
        }
    }
}

