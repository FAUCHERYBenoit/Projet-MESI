using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "New Data/Weapon")]
public class WeaponData : ScriptableObject
{
    public GameObject model;
    public GameObject bullet;
    public float damage;
    public float fireRate;
    public Vector3 position;
}
