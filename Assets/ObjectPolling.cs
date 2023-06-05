using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPolling : MonoBehaviour
{
    public static ObjectPolling inst;
    public List<GameObject> circleslist = new List<GameObject>();
    public int amount = 4;
    public GameObject prefeb;
    public float offset = 5f;

    private void Awake()
    {
        inst = this;
    }
    void Start()
    {
        for (int i = 0; i < amount; i++)
        {
            GameObject obj = Instantiate(prefeb);
            obj.SetActive(false);
            circleslist.Add(obj);

        }
    }
    public GameObject GetPipe()
    {
        for (int i = 0; i < circleslist.Count; i++)
        {
            if (!circleslist[i].activeInHierarchy)
            {
                return circleslist[i];
               


            }
        }
        return null;
    }

}
