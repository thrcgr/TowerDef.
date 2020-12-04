using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class pauseMenu : MonoBehaviour
{

    public GameObject ui;

    public string menuSceneName = "MainMenu";

    public sceneFader sceneFader;
    private WaveSpawner waveSpawner;
    private wave wave;
    
    

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.P))
        {
            Toggle();
        }
    }

    public void Toggle()
    {
        ui.SetActive(!ui.activeSelf);

        if (ui.activeSelf)
        {
            Time.timeScale = 0f;
        }
        else
        {
            Time.timeScale = 1f;
        }
    }

    //public void Retry()
    //{
    //    Toggle();
    //    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    //}

    public void Menu()
    {

        WaveSpawner.EnemiesAlive = 0; //////////////////////////////////////////////////////
        WaveSpawner.countdown = 2f;
        Time.timeScale = 1f;


        
        
        SceneManager.LoadScene(menuSceneName);
        
        
    }

}