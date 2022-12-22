using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float health = 50f;
    public Health healthBar; 
    void Start()
    {
        healthBar.SetMaxHealth(health); 
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage(20);
        }
    }
    public void TakeDamage(float damage)
    {
        health -= damage;
        healthBar.SetHealth(health); 
        if (health <= 0f)
        {
            die();
        }
    }
    void die()
    {
        Destroy(gameObject);
    }
}
