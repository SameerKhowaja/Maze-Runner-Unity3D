using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AI_Controller : MonoBehaviour
{
    public NavMeshAgent agent;
    public Transform PlayerPos;

    private void Start()
    {
        PlayerPos = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void Update()
    {
        agent.speed = Random.Range(0.4f, 1f);
        agent.SetDestination(PlayerPos.position);
    }
}
