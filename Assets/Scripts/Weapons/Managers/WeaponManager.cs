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
        [SerializeField] Transform poolTransform;
        [SerializeField] Weapons_Item currentWeapon;
        [SerializeField] Weapon currentEquippedWeapon;

        [Header("pooling params")]
        BulletCollider[] bulletColliders;
        [SerializeField] float bulletAutoDestructionTimer;
        float fireTimer = 0;

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
            if(fireTimer + currentWeapon.FireRate < Time.time)
            {
                fireTimer = Time.time;

                if (bulletColliders[poolCounter] == null)
                {
                    bulletColliders[poolCounter] = Instantiate(currentWeapon.DefaultBullet.BulletPrefab, currentEquippedWeapon.ShootTransforms[0]).GetComponent<BulletCollider>();
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
        }

        private void HandleInflictDamage(BulletCollider bullet, DamageData data, TakeDamageCollider target)
        {
            target.TakeDamage(data);
            ResetBullet(bullet);
        }

        private void ResetBullet(BulletCollider bullet)
        {
            bullet.CloseCollider();
            bullet.transform.SetParent(currentEquippedWeapon.ShootTransforms[0]);
            bullet.gameObject.transform.position = currentEquippedWeapon.ShootTransforms[0].position;
            bullet.gameObject.transform.localRotation = currentEquippedWeapon.transform.localRotation;
            bullet.Rb.velocity = Vector3.zero; 
            bullet.gameObject.SetActive(false);
        }
    }
}

