using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Rigidbody2D rigidbody2d;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        BallJump();
    }
    public void BallJump()
    {
        if(Input.GetMouseButtonDown(0))
        {
            rigidbody2d.velocity = Vector2.up * 5;
        }
    }

}
