using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine.UI;

public class WaveSpawner : MonoBehaviour
{
    public static WaveSpawner instance;
    public static int EnemiesAlive = 0;
    public static float countdown = 2f;

    
    public wave[] waves;

    public Transform spawnPoint;

    public float timeBetweenWaves = 5f;

    //public float countdown = 2f;

    public Text waveCountdownText;

    public gameManager gameManager;

    private int waveIndex = 0;

    

    void Awake()
    {
        
        instance = this;
        
    }
    void Update()
    {
        
        


        if (playerStats.Lives <= 0)   //////////////////////////////////////////+++++++++++++++++++++++++++++++++++++
        {
            waveCountdownText.enabled = false;
            countdown = 1f;
            playerStats.Lives = 0;

        }


        if (EnemiesAlive > 0)
        {
            
            return;
        }

        if (waveIndex ==  waves.Length)
        {
            gameManager.WinLevel();
            this.enabled = false;
        }

        if (countdown <= 0f)
        {
         //    if (playerStats.Lives <= 0)
        //{
        //    //timeBetweenWaves = 100f;
        //    StopCoroutine(SpawnWave());

        //}
            StartCoroutine(SpawnWave());
            
            countdown = timeBetweenWaves;
            return;
        }

        countdown -= Time.deltaTime;

        countdown = Mathf.Clamp(countdown, 0f, Mathf.Infinity);

        waveCountdownText.text = string.Format("{0:00.00}", countdown);
    }

    

    IEnumerator SpawnWave()
    {
        playerStats.Rounds++;

        wave wave = waves[waveIndex];

        EnemiesAlive = wave.count;

        for (int i = 0; i < wave.count; i++)
        {
            SpawnEnemy(wave.enemy);
            yield return new WaitForSeconds(wave.rate/1f);
            
        }
        


        waveIndex++;
        
    }
    public List<GameObject> enemies=new List<GameObject>();
    void SpawnEnemy(GameObject enemy)
    {
        enemies.Add(Instantiate(enemy, spawnPoint.position, spawnPoint.rotation));

    }
    
    
}