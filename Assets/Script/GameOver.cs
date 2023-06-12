using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : screen
{
    private void Start()
    {
        //GamePlay.inst.ballpartical.Stop();
    }
    public void OnHomeButtonClick()
    { 
        UIManager.inst.ShowNextScreen(ScreenEnum.MainMenu);
    }
}
