using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public int score = 0;
  

   
    private void Awake()
    {
      
        ScoreManager.inst.scoretxt.text = PlayerPrefs.GetInt("Score", 0).ToString();

    }
    private void Update()
    {
        PlayerPrefs.SetInt("Score", score);
    }
    public void Reset()
    {
        PlayerPrefs.DeleteAll();
        ScoreManager.inst.scoretxt.text = "0";
       

    }
    
}
