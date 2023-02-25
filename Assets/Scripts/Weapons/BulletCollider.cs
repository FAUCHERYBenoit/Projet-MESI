using character;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace combat
{
    public class BulletCollider : MonoBehaviour
    {
        [SerializeField] Collider2D collider2D;
        [SerializeField] LayerMask layerMask;
        [HideInInspector] public InflictDamageEvent onInflictDamage = new InflictDamageEvent();
        public DamageData damage { get; private set; }
        public void SetDamageData(DamageData damageData)
        {
            this.damage = damageData;
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.layer == layerMask)
            {
                AbstractCharacterManager character = collision.GetComponent<AbstractCharacterManager>();
                onInflictDamage.Invoke(damage, character);
            }
        }
    }
}

