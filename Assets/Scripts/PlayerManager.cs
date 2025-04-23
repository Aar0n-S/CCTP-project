//using System.Collections;
//using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public static bool isGameOver;

    //awake is called just before start 
    private void Awake()
    {
        isGameOver = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isGameOver == true)
        {
            //SceneManager.LoadScene("Level01");
            Debug.Log("game over");
        }
    }
}
