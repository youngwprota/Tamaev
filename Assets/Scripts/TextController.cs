using System.Collections;
using UnityEngine;
using TMPro;

public class TextController : MonoBehaviour
{
    public TMP_Text hpText; 
    public TMP_Text scoreText; 


    void Start()
    {
        UpdateHpText();
        UpdateScoreText();
    }

    void Update()
    {
        UpdateHpText(); 
        UpdateScoreText();
    }

    void UpdateHpText()
    {
        hpText.text = "HP: " + Player.hp.ToString(); 
    }

    void UpdateScoreText()
    {
        scoreText.text = Score.levelScore.ToString() + "/" + Score.prefScore.ToString(); 
    }


}
