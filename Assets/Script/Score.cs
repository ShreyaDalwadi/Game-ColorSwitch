using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public int score = 0;
  

    public void OnTriggerEnter2D(Collider2D collision)
    {

        score = score + 1;
        ScoreManager.inst.scoretxt.text = score.ToString();
        Debug.Log("scoree" + score);
        Destroy(gameObject);
    }
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
