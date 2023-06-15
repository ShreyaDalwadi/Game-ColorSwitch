using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GamePlay :screen
{

    public static GamePlay inst;
    public GameObject hand;
    public Text pptTxt;
    //public Image image;
    public Animator animator;
    //public float second = 2f;
    //public float target = 0f;
    //private float currentAlpha;
    public GameObject emptyobj;
    private void Start()
    {
        //currentAlpha = image.color.a;
        Ball.inst.part.Stop();
    }
    private void Update()
    {
        
    }
    public void OnPauseButtonClick()
    {
        UIManager.inst.ShowNextScreen(ScreenEnum.Pause);
        Ball.inst.ball.SetActive(false);
        MainMenu.inst.Onreset();
        Ball.inst.rigidbody2d.constraints = RigidbodyConstraints2D.FreezeAll;

    }
    //IEnumerator Fade()
    //{
    //    //start to end time of event
    //    float elapsedTime = Time.time;
    //    //Debug.Log("elapsed" + elapsedTime);
    //    Debug.Log("Time" + Time.time);
    //    float newAlpha = Mathf.Lerp(currentAlpha, target, elapsedTime / second);

    //    Color newColor = image.color;
    //    newColor.a = newAlpha;
    //    image.color = newColor;
    //    yield return image.color;
    //}

}


