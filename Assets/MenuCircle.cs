using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuCircle : MonoBehaviour
{
    public float speed = 40f;
    public GameObject c1;
    public GameObject c2;
    public GameObject c3;
    public GameObject tc1;
    public GameObject tc2;


    public void Update()
    {

        c1.transform.Rotate(0f, 0f, speed * Time.deltaTime);
        c2.transform.Rotate(0f, 0f, -speed * Time.deltaTime);
        c3.transform.Rotate(0f, 0f, speed * Time.deltaTime);
        tc1.transform.Rotate(0f, 0f, speed * Time.deltaTime);
        tc2.transform.Rotate(0f, 0f, -speed * Time.deltaTime);

    }

}
