using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour

{
    public int score = 0;
    public Text scoretxt;
    public static ScoreManager inst;

    private void Awake()
    {
        inst = this;
    }
    public void IncreseScore(int value)
    {
        score = score + value;
        scoretxt.text = score.ToString();
    }

}