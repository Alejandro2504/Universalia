using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Puntos : MonoBehaviour
{
    public float puntos;
    public TextMeshProUGUI textoPuntos;

    internal void AgregarPuntos(float puntosQueDa)
    {
        throw new NotImplementedException();
    }

    private void Update()
    {
        textoPuntos.text = "Puntos: " + puntos.ToString();

        if (puntos < 0)
        {
            puntos = 0;
         }
     }
}
