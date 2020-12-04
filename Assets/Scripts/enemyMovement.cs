using UnityEngine;
using System.Collections;
//
using UnityEngine.UI;

[RequireComponent(typeof(enemy))]
public class enemyMovement : MonoBehaviour
{

    private Transform target;

    private int wavepointIndex = 0;

    private enemy enemy;




    void Start()
    {
        enemy = GetComponent<enemy>();

        target = waypoints.points[0];
    }


    void Update()
    {
        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized * enemy.speed * Time.deltaTime, Space.World);
        transform.rotation=Quaternion.LookRotation(dir);

        if (Vector3.Distance(transform.position, target.position) <= 0.4f)
        {
            if (playerStats.Lives<=0)   //////////////////////////////////////////+++++++++++++++++++++++++++++++++++++
            {
                WaveSpawner.EnemiesAlive = 0; ///////////////////////////////+++++++

            }
            GetNextWaypoint();

        }

        enemy.speed = enemy.startSpeed;
    }


    void GetNextWaypoint()
    {
        if (wavepointIndex >= waypoints.points.Length - 1)
        {
            EndPath();
            return;
        }

        wavepointIndex++;
        target = waypoints.points[wavepointIndex];
    }

    
    

    void EndPath()
    {
        playerStats.Lives--;

        WaveSpawner.EnemiesAlive--;
        Destroy(gameObject);
        
    }

}