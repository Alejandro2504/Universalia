using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Soles : MonoBehaviour
{
    public GameObject objPuntos;
    public float puntosQueDa;


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")

           
        {
            objPuntos.GetComponent<Puntos>().puntos += puntosQueDa;
              Destroy(gameObject);
        }
    }
}
