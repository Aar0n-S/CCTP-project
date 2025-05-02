using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnMenuScript : MonoBehaviour
{
    
    //return to the main menu
    public void ReturnMenuButton()
    {
        //returns the user to the main menu from the crowd scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    } 
}
