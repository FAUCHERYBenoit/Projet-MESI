using character;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace combat
{
    [Serializable]
    public class DamageData
    {
        public DamageData(float damageAmount)
        {
            this.damageAmount = damageAmount;
        }

        [SerializeField] float damageAmount;

        public float DamageAmount { get => damageAmount; }
    }

    /// <summary>
    /// An event that inflicts damage to a target characters
    /// </summary>
    public class InflictDamageEvent : UnityEvent<DamageData, AbstractCharacterManager> { }
    public class TakeDamageEvent : UnityEvent<DamageData> { }
    public class DodgeEvent : UnityEvent { }
    public class ShootBulletEvent : UnityEvent { }
}

