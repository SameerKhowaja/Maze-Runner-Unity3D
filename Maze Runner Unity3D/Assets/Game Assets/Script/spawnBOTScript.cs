using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnBOTScript : MonoBehaviour
{
    public Transform[] points;
    public GameObject AI_BOT;

    public float TimeToSpawn;
    public float ResetTimer;

    private void Update()
    {
        if (TimeToSpawn <= 0)
        {
            int randomPoint = Random.Range(0, points.Length);
            Instantiate(AI_BOT, points[randomPoint].position, Quaternion.identity);
            TimeToSpawn += ResetTimer;
        }
        else
        {
            TimeToSpawn -= Time.deltaTime;
        }
    }
}
