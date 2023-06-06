using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : MonoBehaviour
{
    public float speed = 20f;

    public void Update()
    {

        OnRotate();

    }
    void OnRotate()
    {
        transform.Rotate(0f, 0f, speed * Time.deltaTime);
    }
}
