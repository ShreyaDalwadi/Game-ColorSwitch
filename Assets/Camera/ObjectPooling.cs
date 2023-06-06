using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPooling : MonoBehaviour
{

    public List<GameObject> RingsObjects;
    public List<GameObject> SpwanList;
    public GameObject spwanPoint;
    public int ringCount=5;

    public static ObjectPooling inst;

    private void Awake()
    {
        inst = this;

    }

    void Start()
    {
        for (int i = 0; i < 2; i++)
        {
            SpwanerRing();
        }
    }
    
    public void SpwanerRing()
    {
        GameObject random = Instantiate(RingsObjects[Random.Range(0, RingsObjects.Count)]);
        random.transform.position = RandomSpwanPoint();
        SpwanList.Add(random);
    }

    public Vector2 RandomSpwanPoint()
    {
        float xvalue = Random.Range(0f, 0f);
        float yvalue = Random.Range(4.2f, 4.2f);
        spwanPoint.transform.position = new Vector2(spwanPoint.transform.position.x + xvalue, spwanPoint.transform.position.y + yvalue);
        return spwanPoint.transform.position;

    }
}




