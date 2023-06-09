using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu :screen
{
    public GameObject ballprefeb;
    public GameObject colorchangePrefeb;
    public List<GameObject> ringList;
    public List<GameObject> SpwanList;
    public GameObject spwanPoint;
    public static MainMenu inst;
    public GameObject ball;

   
    private void Start()
    {
        inst = this;
        UIManager.inst.ShowNextScreen(ScreenEnum.MainMenu);
        SpawnBall();

    }
    public  void OnButtonClick()
    {
        UIManager.inst.ShowNextScreen(ScreenEnum.GamePlay);
        ball.SetActive(true);
        SetObjectsActive();
        Debug.Log("SetObj");
        //Score.inst.Reset();
    }
    public void SpawnBall()
    {
         ball= Instantiate(ballprefeb, Vector3.zero, Quaternion.identity);
        ball.SetActive(false);
    }


    public void SetObjectsActive()
    {
        for (int i = 0; i < ringList.Count; i++)
        {
           //Instantiate(colorchangePrefeb, new Vector3(0,2f, 0), Quaternion.identity);
            GameObject random = Instantiate(ringList[Random.Range(0, ringList.Count)]);
            random.transform.position = RandomSpwanPoint();
            SpwanList.Add(random);
        }


    }
    public Vector2 RandomSpwanPoint()
    {
        float xvalue = Random.Range(0f, 0f);
        float yvalue = Random.Range(5f, 5f);
        spwanPoint.transform.position = new Vector2(spwanPoint.transform.position.x + xvalue, spwanPoint.transform.position.y + yvalue);
        return spwanPoint.transform.position;

    }
    public void Onreset()
    {
        for (int i = 0; i < SpwanList.Count; i++)
        {
            Destroy(SpwanList[i].gameObject);
            //SpwanList[i].gameObject.transform.position = new Vector3(0, 0, 0);
            //Debug.Log("reset" + transform.position);
        
        }
        SpwanList.Clear();
        spwanPoint.transform.position = new Vector3(0, 0, 0);
        Debug.Log("reset" + transform.position);



    }


}
