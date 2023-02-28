using character.stat;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using System.Linq;

namespace character.ai
{
    public class NPCBrain : MonoBehaviour
    {
        List<AbstractActivity> states = new List<AbstractActivity>();

        private void Awake()
        {
            states.ForEach(s =>
            {
                s.onStateChange.AddListener(newState => HandleState(newState));
            });
        }

        public void HandleState(AI_States aI_States)
        {
            List<AbstractActivity> possibleState = states.Where(state => state.aI_States == aI_States).ToList();
            possibleState[Random.Range(0, possibleState.Count)].RunActivity();
        }
    }

    public class AIStateEvent : UnityEvent<AI_States> { }

    public abstract class AbstractActivity : MonoBehaviour
    {
        public AbstractActivity(AI_States aI_States)
        {
            this.aI_States = aI_States;
        }

        public AI_States aI_States;
        public AIStateEvent onStateChange = new AIStateEvent();
        public abstract void RunActivity();
    }

    public enum AI_States
    {
        Appearing,
        Idle,
        LookingForTarget,
        ChasingTarget,
        Attacking,
        Dying,
    }
}

