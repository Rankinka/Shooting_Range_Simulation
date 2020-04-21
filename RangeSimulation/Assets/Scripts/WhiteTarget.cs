using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhiteTarget : MonoBehaviour
{
    void DeductPoints(int damage)
    {
        Score.currentScore += 2;
        Score.totalHit += 1.0f;
    }
    void Update()
    {
        
    }
}
