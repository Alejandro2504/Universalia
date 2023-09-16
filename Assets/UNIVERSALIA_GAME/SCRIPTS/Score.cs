using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    public static Score instance;
    public RepairMachine repair;
    public TMP_Text text;
    int score;
    void Start()
    {
        if(instance == null)
        {
            instance = this;
        }
    }
    public void ChangeScore(int theScore)
    {
        score += 1;
        text.text = "Score = " + score.ToString();

        if (score >= 6)
        {
            repair.boxContainer.SetActive(true);
        }
    }
}
