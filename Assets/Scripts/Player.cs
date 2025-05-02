using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //sets maximum possible health
    public int maxHealth = 100;
    //used so the starting health is always the max value 
    public int currentHealth;

    public HealthBar healthBar;
    
    // Start is called before the first frame update
    void Start()
    {
        //sets starting health
        currentHealth = maxHealth;
        //the health bar from the HealthBar script is called to pass in max health
        healthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {

        //if the players health is <= 0 then isGameOver is called when it is set to true
        if (currentHealth <= 0)
        {
            PlayerManager.isGameOver = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        //if the player collides with an entity with the NPC tag they loose 20 health
        if(other.tag == "NPC")
        {
            TakeDamage(20);
        }
    }

    //manages health decrease
    void TakeDamage(int damage)
    {
        //reduces hralth 
        currentHealth -= damage;
        //updates the healthbar
        healthBar.SetHealth(currentHealth);
    }

}
