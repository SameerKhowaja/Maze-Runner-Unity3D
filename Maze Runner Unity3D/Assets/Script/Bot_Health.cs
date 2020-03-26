using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bot_Health : MonoBehaviour
{
    public float health;
    public AI_Controller AI;
    public Animator spiderAnimator;

    private void Start()
    {
        health = Random.Range(30f, 60f);
    }

    public void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0)
        {
            AI.enabled = false;
            spiderAnimator.SetBool("isDie", true);
            DestroyBOT();
        }
    }

    void DestroyBOT()
    {
        Destroy(gameObject, 3f);
    }
}
