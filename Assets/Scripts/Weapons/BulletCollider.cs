using character;
using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace combat
{
    public class BulletCollider : MonoBehaviour
    {
        [SerializeField] Rigidbody2D rb;
        [SerializeField] Collider2D collider2D;
        [SerializeField] LayerMask layerMask;
        [HideInInspector] public InflictDamageEvent onInflictDamage = new InflictDamageEvent();
        [HideInInspector] public UnityEvent<BulletCollider> onTimeOut = new UnityEvent<BulletCollider>();

        public DamageData damage { get; private set; }
        public Rigidbody2D Rb { get => rb; }

        public void SetDamageData(DamageData damageData)
        {
            this.damage = damageData;
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.layer == layerMask)
            {
                TakeDamageCollider takeDamageCollider = collision.GetComponent<TakeDamageCollider>();
                onInflictDamage.Invoke(this, damage, takeDamageCollider);
            }
        }

        public void OpenCollider(float timer)
        {
            collider2D.enabled = true;
            StartCoroutine(BulletAutoDestruction(timer));
        }

        public void CloseCollider()
        {
            collider2D.enabled = false;
        }

        IEnumerator BulletAutoDestruction(float timer)
        {
            yield return new WaitForSeconds(timer);
            onTimeOut?.Invoke(this);
        }
    }
}

