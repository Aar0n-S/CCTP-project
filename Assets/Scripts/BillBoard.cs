using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BillBoard : MonoBehaviour
{

    public Transform cam;
    

    // lateUpdate is used due to update causing some visual issues 
    //It will be called after the normal update so the camera will move then it will update
    void LateUpdate()
    {
        //makes the health bar face the main camera
        transform.LookAt(transform.position + cam.forward);
    }
}
