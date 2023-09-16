using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collect : MonoBehaviour
{
    //public AudioSource collectSound;
    public int theScore = 1;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Sun"))
        {
            //collectSound.Play();
            Score.instance.ChangeScore(theScore);
            other.gameObject.SetActive(false);
        }
    }
}
