using UnityEngine;
using System.Collections;
//using UnityEditor.Build.Content;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class gameManager : MonoBehaviour
{
    public GameObject enemy;
    public static bool GameIsOver;

    //public Text wavecountdownText;
    public GameObject gameOverUI;
    public GameObject completeLevelUI;

    
    
    
    void Start()
    {
        GameIsOver = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (GameIsOver)
            return;

        if (playerStats.Lives <= 0)
        {
            //Destroy(GameObject.FindWithTag("enemy"));
            EndGame();
            //Thread.Sleep(2000);
            
            
        }
    }

    void EndGame()
    {
        GameIsOver = true;
        gameOverUI.SetActive(true);
        //if (WaveSpawner.instance.enemies.Contains(gameObject))
        //{
        //    WaveSpawner.instance.enemies.Clear();
           
           
        //}

        
        
    }

    public void WinLevel()
    {
        GameIsOver = true;
        completeLevelUI.SetActive(true);
    }

    

}