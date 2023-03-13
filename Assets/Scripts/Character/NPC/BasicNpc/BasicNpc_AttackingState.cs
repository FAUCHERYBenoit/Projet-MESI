using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace character.ai
{
    public class BasicNpc_AttackingState : AbstractActivity
    {
        [SerializeField] List<Collider> colliders = new List<Collider>();
        [SerializeField] int damageAmount;

        private void Awake()
        {
            
        }

        protected override void InitState()
        {
            base.InitState();
        }

        protected override void DoStateLogique()
        {
            
        }

        protected override AI_States GetNextState()
        {
            return AI_States.ChasingTarget;
        }

        protected override bool IsStillActive(bool isIt = true)
        {
            return true;
            //throw new System.NotImplementedException();
        }
    }
}

