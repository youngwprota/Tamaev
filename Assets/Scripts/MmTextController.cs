using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class MmTextController : MonoBehaviour
{
    public TMP_Text allScoreText; 
    void Update()
    {
        UpdateAllScoreText();
        
    }

    void Start()
    {
        Score.score = PlayerPrefs.GetFloat("Score", 100f); 
        UpdateAllScoreText();
    }

    void UpdateAllScoreText()
    {
        allScoreText.text = "Бабки: " + Score.score.ToString();
    }
}
