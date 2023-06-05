using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : MonoBehaviour
{
    public float speed = 40f;

    public void Update()
    {

       transform.Rotate(0f, 0f, speed * Time.deltaTime);

    }
}
