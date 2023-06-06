using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public static Ball inst;
    public Rigidbody2D rigidbody2d;
    public _Color[] colorlist;
    public Renderer ballrenderer;
  public int currentIndex = 0;
    

    void Start()
    {
        inst = this;
       
    }
    private void Awake()
    {
        ballrenderer = GetComponent<Renderer>();
    }

    void Update()
    {
        BallJump();
       
    }
    public void BallJump()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rigidbody2d.velocity = Vector2.up * 5;
        }
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("pink"))
        {
            Debug.Log("pink");
        }
        if (collision.gameObject.CompareTag("blue"))
        {
            Debug.Log("blue");
        }
        if (collision.gameObject.CompareTag("yellow"))
        {
            Debug.Log("yellow");
        }
        if (collision.gameObject.CompareTag("purple"))
        {
            Debug.Log("purple");
        }
        if (collision.gameObject.CompareTag("colorchange"))
        {
            
        }

    }
    [System.Serializable]
    public class _Color
    {
        public ColorType name;
        public Color colors;

    }
    public enum ColorType
    {
        Pink,
        Blue,
        Purple,
        Yellow

    }

}
