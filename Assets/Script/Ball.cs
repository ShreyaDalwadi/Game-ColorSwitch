using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class Ball : MonoBehaviour
{

    public colorType currentcolor;
    public static Ball inst;
    public Rigidbody2D rigidbody2d;
    public SpriteRenderer spriterenderer;



    void Start()
    {
        inst = this;
        spriterenderer = GetComponent<SpriteRenderer>();
    }


    void Update()
    {
        BallJump();

    }

    public void BallJump()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rigidbody2d.velocity = Vector2.up * 3;
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("star"))
        {


            ScoreManager.inst.IncreseScore(1);
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.CompareTag("colorchange"))
        {
            Debug.Log("name" + collision.gameObject.name);
            spriterenderer.color = collision.GetComponent<ColorManager>().ColorChange();
            Debug.Log("change color" + spriterenderer.color);
        }

        else if (currentcolor == collision.GetComponent<Part>().colorType)
        {
            Debug.Log("ball match");
        }
        else
        {
            MainMenu.inst.ball.SetActive(false);
            Destroy(gameObject);
            MainMenu.inst.Onreset();
            UIManager.inst.ShowNextScreen(ScreenEnum.GameOver);
            Debug.Log("ball destroy");
        }
    }
}



