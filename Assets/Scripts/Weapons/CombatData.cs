using character;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace combat
{
    public class DamageData
    {
        public DamageData(float damageAmount)
        {
            this.damageAmount = damageAmount;
        }   

        public float damageAmount { get; private set; }
    }

    /// <summary>
    /// An event that inflicts damage to a target characters
    /// </summary>
    public class InflictDamageEvent : UnityEvent<DamageData, AbstractCharacterManager> { }
    public class TakeDamageEvent : UnityEvent<DamageData> { }
    public class DodgeEvent : UnityEvent { }
}

