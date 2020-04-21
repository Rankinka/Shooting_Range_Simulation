using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueTarget : MonoBehaviour
{
    void DeductPoints(int damage)
    {
        Score.currentScore += 1;
        Score.totalHit += 1.0f;
    }
    void Update()
    {
        
    }
}
