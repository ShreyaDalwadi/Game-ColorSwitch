using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScreen : screen
{
    public void OnPlayButtonClick()
    {
        UIManager.inst.ShowNextScreen(ScreenEnum.GamePlay);
        Ball.inst.ball.SetActive(true);
        Ball.inst.rigidbody2d.isKinematic = false;
      
    }
    public void OnHomeeButtonClick()
    {
        UIManager.inst.ShowNextScreen(ScreenEnum.MainMenu);
        Audio.inst.SoundPlay(Audio.SoundName.Buttons);
        ScoreManager.inst.Reset();
        MainMenu.inst.Onreset();
        

    }
}
