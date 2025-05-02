using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
   //load the scene 
    public void Play()
    {
        //changes the scene index to the crowd scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void PlayMaze()
    {
        //changes the scene index to the maze scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
    }

    //quit the game
    public void Quit()
    {
        Application.Quit();
        //Debug.Log("palyer has quit");
    }

}
