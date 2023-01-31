using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponControl : MonoBehaviour
{
    [Header("Data")]
    public WeaponData weaponData;

    [Header("Transforms")]
    public Transform playerRotation;
    //Akimbo
    public Transform leftHandPos;

    private void Start()
    {
        if (weaponData != null)
        {
            LoadWeapon(weaponData);
        }
    }

    private void LoadWeapon(WeaponData _data)
    {
        // Supprime tous les child de l'empty s'il y en a 
        foreach (Transform child in transform)
        {
            if (Application.isEditor)
            {
                DestroyImmediate(child.gameObject);
            }
            else
            {
                Destroy(child.gameObject);
            }
        }

        // Fait apparaitre le modèle 3D et le configure
        GameObject visuals = Instantiate(weaponData.model);
        visuals.transform.SetParent(transform);
        visuals.transform.localPosition = weaponData.position;
        visuals.transform.rotation = Quaternion.Euler(
            playerRotation.rotation.eulerAngles.x, 
            playerRotation.rotation.eulerAngles.y, 
            playerRotation.rotation.eulerAngles.z -90
            );

        visuals.GetComponent<WeaponStats>().damage = weaponData.damage;
        visuals.GetComponent<WeaponStats>().fireRate = weaponData.fireRate;
    }
}
