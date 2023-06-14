using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GamePlay :screen
{
    private void Start()
    {
    Ball.inst.part.Stop();
    }
    public void OnPauseButtonClick()
    {
        UIManager.inst.ShowNextScreen(ScreenEnum.Pause);
        MainMenu.inst.ball.SetActive(false);
        MainMenu.inst.Onreset();
       
    }

}


