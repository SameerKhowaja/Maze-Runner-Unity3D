using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AI_Controller : MonoBehaviour
{
    public NavMeshAgent agent;
    public Transform PlayerPos;
    public PlayerHealth playerHealth;
    public Animator spiderAnimation;

    public float HitDistance;

    private void Start()
    {
        PlayerPos = GameObject.FindGameObjectWithTag("Player").transform;
        playerHealth = PlayerPos.transform.GetComponent<PlayerHealth>();
    }

    private void Update()
    {
        agent.speed = Random.Range(0.2f, 1f);
        agent.SetDestination(PlayerPos.position);
        
        if (Vector3.Distance(this.transform.position, PlayerPos.transform.position) <= HitDistance)
        {
            spiderAnimation.SetBool("allowAttack", true);
            DecreasePlayerHealth();
        }
        else
        {
            spiderAnimation.SetBool("allowAttack", false);
        }
    }

    void DecreasePlayerHealth()
    {
        if (playerHealth != null)
            playerHealth.Health -= 0.1f;
    }
}
