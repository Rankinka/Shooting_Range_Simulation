using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandGunReload : MonoBehaviour
{
    public AudioSource reload;
    public GameObject CrossObject;
    public GameObject MechanicsObject;
    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            ActionReload();

            reload.Play();

            StartCoroutine(EnableScripts());
        }
    }
    IEnumerator EnableScripts()
    {
        yield return new WaitForSeconds(1.1f);
        CrossObject.SetActive(true);
        MechanicsObject.SetActive(true);
    }

    void ActionReload()
    {
        int ammoCount = Ammo.CurrentAmmo;
        ammoCount = 15 - ammoCount;
        Ammo.CurrentAmmo += ammoCount;

        CrossObject.SetActive(false);
        MechanicsObject.SetActive(false);
        reload.Play();
        GetComponent<Animation>().Play("M9Reload");
    }
}
