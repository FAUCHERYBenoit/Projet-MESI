using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponControl : MonoBehaviour
{
    public WeaponData weaponData;
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
        visuals.transform.localPosition = Vector3.zero;
        visuals.transform.rotation = Quaternion.identity;

        visuals.GetComponent<WeaponStats>().damage = weaponData.damage;
        visuals.GetComponent<WeaponStats>().fireRate = weaponData.fireRate;
    }
}
