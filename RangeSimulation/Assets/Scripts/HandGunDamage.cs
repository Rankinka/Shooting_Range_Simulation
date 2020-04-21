using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandGunDamage : MonoBehaviour
{
    int damageAmount = 5;
    float targetDistance;
    float allowedRange = 100.0f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            RaycastHit shot;
            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out shot))
            {
                targetDistance = shot.distance;
                if (targetDistance < allowedRange)
                {
                    shot.transform.SendMessage("DeductPoints", damageAmount);
                }
            }
        }
    }
}
