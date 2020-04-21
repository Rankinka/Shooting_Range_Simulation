using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedTarget : MonoBehaviour
{
    void DeductPoints(int damage)
    {
        Score.currentScore += 5;
        Score.totalHit += 1.0f;
    }
    void Update()
    {
        
    }
}
