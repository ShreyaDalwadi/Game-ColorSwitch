using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : screen
{
    private void Start()
    {
       Ball.inst.part.Stop();
      
    }
    public void OnHomeButtonClick()
    { 
        UIManager.inst.ShowNextScreen(ScreenEnum.MainMenu);
        Audio.inst.SoundPlay(Audio.SoundName.Buttons);
        ScoreManager.inst.Reset();
    }
    public void OnTryButtonClick()
    {
        UIManager.inst.ShowNextScreen(ScreenEnum.GamePlay);
        Audio.inst.SoundPlay(Audio.SoundName.Try);
        MainMenu.inst.ball.SetActive(true);
        MainMenu.inst.SetObjectsActive();

    }
}
