using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
    public Button playButton;        
    public Button aboutButton;       

    public Button quitButton;       

    public GameObject aboutCanvas;   

    void Start (){
        playButton.interactable = true;
        aboutButton.interactable = true;
        quitButton.interactable = true;

        
        aboutCanvas.SetActive(false);
    }

    public void LoadGameScene()
    {
        SceneManager.LoadScene("Game");
    }

    public void LoadBetScene()
    {
        SceneManager.LoadScene("Bet");
    }

    public void LoadMainMenuScene()
    {
        SceneManager.LoadScene("MainMenu");
    }


    public void LoadAboutScene()
    {
        playButton.interactable = false;
        aboutButton.interactable = false;
        quitButton.interactable = false;

        
        aboutCanvas.SetActive(true);
    }

    public void ExitAboutScene()
    {
        playButton.interactable = true;
        aboutButton.interactable = true;
        quitButton.interactable = true;

        
        aboutCanvas.SetActive(false);
    }

    public void LoadLooseScene()
    {
        SceneManager.LoadScene("Loose");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
