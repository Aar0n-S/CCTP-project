using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartButtonScript : MonoBehaviour
{
    
    //reset to the game scene
    public void RestartGame()
    {
        //restarts the crowd scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

}
