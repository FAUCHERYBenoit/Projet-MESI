using combat;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace items
{
    public class Weapons_Item : Items
    {
        [SerializeField] GameObject weaponPrefab;
        [SerializeField] DamageData damageData;
        [SerializeField] GameObject defaultBulletPrefab;

        public GameObject WeaponPrefab { get => weaponPrefab; }
        public DamageData DamageData { get => damageData; }
        public GameObject DefaultBulletPrefab { get => defaultBulletPrefab; }
    }
}

