using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class completeLevel : MonoBehaviour
{

    public string menuSceneName = "MainMenu";

    public string nextLevel = "2";
    public int levelToUnlock = 2;

    public sceneFader sceneFader;

    public void Continue()
    {
        PlayerPrefs.SetInt("levelReached", levelToUnlock);
        SceneManager.LoadScene(nextLevel);
    }

    public void Menu()
    {
        SceneManager.LoadScene(menuSceneName);
    }

}