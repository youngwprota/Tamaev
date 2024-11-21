using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BetController : MonoBehaviour
{
    public TMP_InputField betInputField;  
    public Button playButton;      

    private bool valid = false; 

    void Start()
    {
        playButton.interactable = false; 
    }

    void Update()
    {
        playButton.interactable = valid;  
    }

    public void OnBetInputChanged()
    {
        if (int.TryParse(betInputField.text, out Score.prefScore) && Score.prefScore >= 0)
        {
            valid = true;  
        }
        else
        {
            valid = false;  
        }
    }
}
