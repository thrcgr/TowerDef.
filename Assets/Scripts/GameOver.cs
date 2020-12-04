using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
//using System.Threading;
public class GameOver : MonoBehaviour
{
    
    public GameObject uigo;
    public string menuSceneName = "MainMenu";
    //public GameObject EnemyGameObject;
    
    //public GameObject spawnPoint;


    //void Awake()
    //{
    //    if (WaveSpawner.instance.enemies.Contains(gameObject));
    //    {
    //        WaveSpawner.instance.enemies.Remove(gameObject);
    //    }

        
    //}
    public void Retry()
    {
        Toggle();

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        //Application.LoadLevel(Application.loadedLevel);

        //waveSpawner.timeBetweenWaves = 2f;

        //Time.timeScale = 1f;
        
        

    }

    public void Menu()
    {
        Toggle();
        //GameObject.Destroy(EnemyGameObject);
        //Thread.Sleep(2000);
        SceneManager.LoadScene(menuSceneName);
    }

    public void Toggle()
    {
        uigo.SetActive(!uigo.activeSelf);
        
        if (uigo.activeSelf)
        {
            Time.timeScale = 0f;
        }
        else
        {
            Time.timeScale = 1f;
        }
    }

}