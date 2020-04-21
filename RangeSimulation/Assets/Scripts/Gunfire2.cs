using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gunfire2 : MonoBehaviour
{
    public AudioSource emptyClip;
    public GameObject MechanicsObject;
    public GameObject CrossObject;
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (Ammo.CurrentAmmo > 0)
            {
                AudioSource gunsound = GetComponent<AudioSource>();
                gunsound.Play();
                GetComponent<Animation>().Play("GunShots");
                Ammo.CurrentAmmo -= 1;
                Score.totalShot += 1.0f;
            }
            if(Ammo.CurrentAmmo == 0)
            {
                emptyClip.Play();
                CrossObject.SetActive(false);
                MechanicsObject.SetActive(false);
            }

        }
    }
}
