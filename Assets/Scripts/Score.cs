using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
public static float levelScore = 0.0f;
public static int prefScore = 0;
public static float score = 100f;
public static float kf;

public static void UpdateCoefficient()
{
    kf = prefScore / 10f;
}

void Start()
{
    levelScore = 0;
    score = PlayerPrefs.GetFloat("Score", 100f); 
    UpdateCoefficient();
}
}
