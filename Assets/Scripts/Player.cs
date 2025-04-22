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
        if (Input.GetKeyDown(KeyCode.Space))
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
