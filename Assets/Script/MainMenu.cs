using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MainMenu : screen
{ 
    //public GameObject ballprefeb;
    public List<GameObject> parentList;
    public List<GameObject> spwanList;
    public GameObject spwanPoint;
    public static MainMenu inst;
    public Text ppttext;

 
    private void Start()
    {
     
        inst = this;
        Ball.inst.part.Stop();
        //GamePlay.inst.pptTxt.enabled = false;
        UIManager.inst.ShowNextScreen(ScreenEnum.MainMenu);
        Debug.Log("hand false");
        ppttext.enabled = false;

       
    }
   


    public void OnButtonClick()
    {
        Audio.inst.SoundPlay(Audio.SoundName.Buttons);
        UIManager.inst.ShowNextScreen(ScreenEnum.GamePlay);
        Debug.Log("partical stop");
        Ball.inst.part.Stop();
        Ball.inst.spriterenderer.enabled = true;
        Ball.inst.ball.SetActive(true);
        ppttext.enabled = true;
        Ball.inst.rigidbody2d.constraints = RigidbodyConstraints2D.None;



    SetObjectsActive();
        ScoreManager.inst.Reset();
    }
    //public void SpawnBall()
    //{
    //   ball = Instantiate(ballprefeb,new Vector3(0,0,0), Quaternion.identity);
    //    ball.SetActive(true);
    //}


    public void SetObjectsActive()
    {
        for (int i = 0; i < parentList.Count; i++)
        {
            GameObject random = Instantiate(parentList[Random.Range(0, parentList.Count)]);
            random.transform.position = RandomSpwanPoint();
            spwanList.Add(random);
        }


    }
    public Vector2 RandomSpwanPoint()
    {
        float xvalue = Random.Range(0f, 0f);
        float yvalue = Random.Range(6f, 6f);
        spwanPoint.transform.position = new Vector2(spwanPoint.transform.position.x + xvalue, spwanPoint.transform.position.y + yvalue);
        return spwanPoint.transform.position;

    }
    public void Onreset()
    {
        for (int i = 0; i < spwanList.Count; i++)
        {
            Destroy(spwanList[i].gameObject);

        }
        spwanList.Clear();
        spwanPoint.transform.position = new Vector3(0, 0, 0);
        Ball.inst.ball.transform.position = new Vector3(0, -1, 0);
        Debug.Log("reset" + transform.position);

    }
   
}
