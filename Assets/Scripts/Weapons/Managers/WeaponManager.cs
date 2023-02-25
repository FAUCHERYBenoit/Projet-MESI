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
        [SerializeField] Weapons_Item currentWeapon;

        BulletCollider[] bulletColliders;

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
                ShootNewBullet();
            }


        }

        private void ShootNewBullet()
        {
            bulletColliders[poolCounter] = Instantiate(currentWeapon.DefaultBullet.BulletPrefab, shootTransform).GetComponent<BulletCollider>();
            bulletColliders[poolCounter].OpenCollider();
        }
    }
}

