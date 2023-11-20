using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleButtons : MonoBehaviour
{
   public GameObject UI, Story_Text; 

    //Button For Start of the Story
    public void StoryButton()
    {
        UI.SetActive(false);
        Story_Text.SetActive(true);
    }
    //Start Level 1
    public void Start_Level_1()
    {
         SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    //Quit Button
    public void Quit_Application()
    {
        Application.Quit();
    }
}
