using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : screen
{

    public GameObject ballprefeb;
    public List<GameObject> parentList;
    public List<GameObject> spwanList;
    public GameObject spwanPoint;
    public static MainMenu inst;
    public GameObject ball;

    private void Start()
    {
        inst = this;
        UIManager.inst.ShowNextScreen(ScreenEnum.MainMenu);
        SpawnBall();

    }

    public void OnButtonClick()
    {
        UIManager.inst.ShowNextScreen(ScreenEnum.GamePlay);
        ball.SetActive(true);
        SetObjectsActive();

        //Score.inst.Reset();
    }
    public void SpawnBall()
    {
        ball = Instantiate(ballprefeb, Vector3.zero, Quaternion.identity);
        ball.SetActive(false);
    }


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
        float yvalue = Random.Range(5f, 5f);
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
        Debug.Log("reset" + transform.position);

    }
   
}
