using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RepairMachine : MonoBehaviour
{
    //private Animator anim;
    //public AudioSource boxSound;
    public GameObject boxContainer;
    public GameObject box;
    public TMP_Text repairText;
    public string textValue;
    public float wait_time;
    private void Start()
    {
        //anim = GetComponent<Animator>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            //boxSound.Play();
            //anim.Play("box_open");
            repairText.text = textValue;
            StartCoroutine(FinishGame());
        }
    }
    IEnumerator FinishGame()
    {
        yield return new WaitForSeconds(wait_time);
        box.SetActive(true);
        repairText.gameObject.SetActive(false);
        Destroy(gameObject);
    }
    

}
