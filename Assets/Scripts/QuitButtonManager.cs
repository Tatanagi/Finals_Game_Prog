using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitButtonManager : MonoBehaviour
{
    //Try Again Level 1
    public void TryAgainLvl1()
    {
        SceneManager.LoadScene("Level 1");
    }

    //Return to Main
    public void Return_To_Main()
    {
        SceneManager.LoadScene("Title");
    }
}
