using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu :screen
{
    public GameObject ballprefeb;
    public List<GameObject> ringList;
    public List<GameObject> SpwanList;
    public GameObject spwanPoint;

    private void Start()
    {
        UIManager.inst.ShowNextScreen(ScreenEnum.MainMenu);


    }
    public  void OnButtonClick()
    {
        UIManager.inst.ShowNextScreen(ScreenEnum.GamePlay);
        Instantiate(ballprefeb, new Vector3(0, 0, 0), Quaternion.identity);
        SetObjectsActive();
        Debug.Log("SetObj");
      
 
    }
   

    public void SetObjectsActive()
    {
        for (int i = 0; i < ringList.Count; i++)
        {
            //Instantiate(ringList[i], new Vector3(0, 0, 0), Quaternion.identity);
            GameObject random = Instantiate(ringList[Random.Range(0, ringList.Count)]);
            random.transform.position = RandomSpwanPoint();
            SpwanList.Add(random);
        }

       
    }
    public Vector2 RandomSpwanPoint()
    {
        float xvalue = Random.Range(0f, 0f);
        float yvalue = Random.Range(4.2f, 4.2f);
        spwanPoint.transform.position = new Vector2(spwanPoint.transform.position.x + xvalue, spwanPoint.transform.position.y + yvalue);
        return spwanPoint.transform.position;

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("colider"))
        {
            Destroy(ballprefeb);
        }

    }

}    
