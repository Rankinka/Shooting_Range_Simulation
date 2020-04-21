using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunFire : MonoBehaviour
{
    public AudioSource shoot;
    public AudioSource emptyClip;
    public GameObject MechanicsObject;
    public GameObject CrossObject;



    void Update()
    {
        //Flash.SetActive(false);
        if (Input.GetButtonDown("Fire1"))
        {

            if (Ammo.CurrentAmmo > 0)
            {
                GetComponent<Animation>().Play("GunShots");
                CrossObject.SetActive(true);
                MechanicsObject.SetActive(true);
                Ammo.CurrentAmmo -= 1;
                shoot.Play();
                Score.totalShot += 1.0f;

            }
            if (Ammo.CurrentAmmo == 0)
            {
                emptyClip.Play();
                CrossObject.SetActive(false);
                MechanicsObject.SetActive(false);

            }

        }
    }
}
