using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    private bool isPaused = false;

    // The Game Pause
    public void TogglePause()
    {
        isPaused = !isPaused;

        Time.timeScale = isPaused ? 0 : 1;

    }
    
    // Unpause the game
    public void ResumeGame()
    {
        isPaused = false;
        Time.timeScale = 1;
    }
    
    //Quit Button
    public void Quit_Application_1()
    {
        Application.Quit();
    }

}
