using combat;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace items
{
    [CreateAssetMenu(menuName = "Item/Weapons")]
    public class Weapons_Item : Items
    {
        [SerializeField] GameObject weaponPrefab;
        [SerializeField] DamageData damageData;
        [SerializeField] Bullets_Item defaultBullet;

        public GameObject WeaponPrefab { get => weaponPrefab; }
        public DamageData DamageData { get => damageData; }
        public Bullets_Item DefaultBullet { get => defaultBullet; }
    }
}

