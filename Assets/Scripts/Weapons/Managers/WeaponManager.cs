using items;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace combat.weapon
{
    public class WeaponManager : MonoBehaviour
    {
        [SerializeField] uint MaximumAmountOfBullets;
        [SerializeField] Transform shootTransform;
        [SerializeField] Transform poolTransform;
        [SerializeField] Weapons_Item currentWeapon;

        [Header("pooling params")]
        BulletCollider[] bulletColliders;
        [SerializeField] float bulletAutoDestructionTimer;

        uint poolCounter;

        private void Awake()
        {
            bulletColliders = new BulletCollider[MaximumAmountOfBullets];
        }

        public void ChangeWeapon(Weapons_Item weapon)
        {
            this.currentWeapon = weapon;
            
            //TO DO handle IK ect ... 
            //Destroy all instancies of the old bullets 
        }

        public virtual void ShootBullet()
        {
            if (bulletColliders[poolCounter] == null)
            {
                bulletColliders[poolCounter] = Instantiate(currentWeapon.DefaultBullet.BulletPrefab, shootTransform).GetComponent<BulletCollider>();
                bulletColliders[poolCounter].onInflictDamage.AddListener((bullet, data, target) => HandleInflictDamage(bullet, data, target));
                bulletColliders[poolCounter].onTimeOut.AddListener((bullet) => ResetBullet(bullet));
                bulletColliders[poolCounter].Rb.gravityScale = 0;
            }

            BulletCollider currentBullet = bulletColliders[poolCounter];
            currentBullet.gameObject.SetActive(true);

            currentBullet.transform.SetParent(poolTransform, true);

            Vector3 Direction = transform.right;
            currentBullet.Rb.AddForce(currentWeapon.BulletSpeed * Direction);

            currentBullet.OpenCollider(bulletAutoDestructionTimer, currentWeapon.DamageData);

            poolCounter++;
            if (poolCounter >= MaximumAmountOfBullets)
            {
                poolCounter = 0;
            }
        }

        private void HandleInflictDamage(BulletCollider bullet, DamageData data, TakeDamageCollider target)
        {
            target.TakeDamage(data);
            ResetBullet(bullet);
        }

        private void ResetBullet(BulletCollider bullet)
        {
            bullet.CloseCollider();
            bullet.transform.SetParent(shootTransform);
            bullet.gameObject.transform.position = shootTransform.position;
            bullet.Rb.velocity = Vector3.zero;
            bullet.gameObject.SetActive(false);
        }
    }
}

