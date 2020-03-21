using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnBOTScript : MonoBehaviour
{
    public Transform[] points;
    public GameObject AI_BOT;

    private void Start()
    {
        int randomPoint = Random.Range(0, points.Length);
        Instantiate(AI_BOT, points[randomPoint].position, Quaternion.identity);
    }
}
