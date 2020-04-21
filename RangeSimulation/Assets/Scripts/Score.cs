using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
    public static int currentScore;
    public int internalScore;
    public static float totalHit;
    public static float totalShot;
    public float internalAccuracy;
    public GameObject ScoreText;
    public GameObject AccuracyText;


    void Update()
    {
        internalScore = currentScore;
        ScoreText.GetComponent<Text>().text = "" + internalScore;
        internalAccuracy = totalHit / totalShot;
        AccuracyText.GetComponent<Text>().text = internalAccuracy.ToString("P");

    }
}
