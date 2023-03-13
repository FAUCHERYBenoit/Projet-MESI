using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace character.ai
{
    public class BasicNpc_ChasingTargetState : AbstractActivity
    {
        [SerializeField] NavMeshAgent navMeshAgent;
        [SerializeField] AI_States nextState;
        [SerializeField] float rotationSpeed;
        private Transform zombieTransform;

        protected override void InitState()
        {
            base.InitState();
            navMeshAgent.isStopped = false;
            zombieTransform = navMeshAgent.transform;
        }

        protected override void DoStateLogique()
        {
            navMeshAgent.SetDestination(GameManager.Instance.PlayerTransform.position);
            RotateTowardWalkDirection();
        }

        protected override AI_States GetNextState()
        {
            return nextState;
        }

        protected override bool IsStillActive(bool isIt = true)
        {
            if (Vector3.Distance(GameManager.Instance.PlayerTransform.position, transform.position) <= navMeshAgent.stoppingDistance + 0.15)
            {
                navMeshAgent.isStopped = true;
                return false;
            }
            return true;
        }

        private void RotateTowardWalkDirection()
        {
            float angle = Mathf.Atan2(navMeshAgent.velocity.y, navMeshAgent.velocity.x) * Mathf.Rad2Deg;
            Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);
            zombieTransform.rotation = Quaternion.Slerp(zombieTransform.rotation, rotation, rotationSpeed);
        }
    }
}
