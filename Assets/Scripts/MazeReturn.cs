using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MazeReturn : MonoBehaviour
{
  
    public void MazeOneMainMenu()
    {
        //return button changes the scene to the main menu
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);
    }

    public void MazeTwoMainMenu()
    {
        //return button changes the scene to the main menu
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 4);
    }
}
