using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiate : MonoBehaviour
{ 

    public GameObject ballprefeb;
    public List<GameObject> ringList;
    public List<GameObject> SpwanList;
    public List<GameObject> starList;
    public GameObject spwanPoint;
    public static Instantiate inst;
    public GameObject ball;
    public GameObject colorchangePrefeb;




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
        StarInst();

        //Score.inst.Reset();
    }
    public void SpawnBall()
    {
        ball = Instantiate(ballprefeb, Vector3.zero, Quaternion.identity);
        ball.SetActive(false);
    }


    public void SetObjectsActive()
    {
        for (int i = 0; i < ringList.Count; i++)
        {
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

        }
        SpwanList.Clear();
        spwanPoint.transform.position = new Vector3(0, 0, 0);
        Debug.Log("reset" + transform.position);

    }
    public void StarInst()
    {
        for (int i = 0; i <= starList.Count; i++)
        {
            Instantiate(starList[i]);
        }

    }


}
