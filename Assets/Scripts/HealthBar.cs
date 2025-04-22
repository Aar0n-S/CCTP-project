using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{

    //creates a slider to move the coloured part of the health bar 
    public Slider slider;

    public void SetMaxHealth(int health)
    {
        //max value is set to the initial health value and updated
        slider.maxValue = health;
        slider.value = health;
    }
    
    public void SetHealth(int health)
    {
        //updates the slider position 
        slider.value = health;
    }
}
