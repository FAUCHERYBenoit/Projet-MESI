using combat;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace items
{
    public class Bullets_Item : MonoBehaviour
    {
        [SerializeField] GameObject bulletPrefab;

        public GameObject BulletPrefab { get => bulletPrefab; }
    }
}

