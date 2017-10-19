using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class apPowerUp : MonoBehaviour {

    public float maxAmmo;

    private void OnCollisionEnter(Collision collision)
    {
        // Controller.currentGun = "ArmorPierce";
        APShoot.apAmmo = maxAmmo;
    }
}
