using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject asteroidPrefab;

    private float timer = 2;

    bool TimerFinished()
    {
        timer -= Time.deltaTime;

        if (timer <= 0)
        {
            timer = 2;
            return true;
        }
        else
        {
            return false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (TimerFinished())
        {
            //Spawn Asteroid
            Vector3 spawnPosition = new Vector3(Random.Range(-23, 23), 30, 0);
            Instantiate(asteroidPrefab, spawnPosition, asteroidPrefab.transform.rotation);
        }
    }
}
