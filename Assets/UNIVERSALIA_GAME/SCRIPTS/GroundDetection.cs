using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundDetection : MonoBehaviour
{
    public PlayerController playerController;

    private void OnTriggerStay(Collider other)
       
    {
        playerController.Isjump = true;
    }

    private void OnTriggerExit(Collider other)


    {
        playerController.Isjump = false;
    }
}
