using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Ammo : MonoBehaviour
{
    public static int CurrentAmmo;
    public int InternalAmmo;
    public GameObject AmmoDisplay;

    void Start()
    {
        CurrentAmmo += 15;
    }
    void Update()
    {

        InternalAmmo = CurrentAmmo;
        AmmoDisplay.GetComponent<Text>().text = "" + InternalAmmo + " / 15";
    }
}
