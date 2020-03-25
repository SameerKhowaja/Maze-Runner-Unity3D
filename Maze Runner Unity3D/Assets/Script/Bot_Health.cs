using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bot_Health : MonoBehaviour
{
    public float health;

    private void Start()
    {
        health = Random.Range(30f, 60f);
    }

    public void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0)
        {
            DestroyBOT();
        }
    }

    void DestroyBOT()
    {
        Destroy(gameObject);
    }
}
