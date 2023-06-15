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
        MainMenu.inst.Onreset();
        Ball.inst.rigidbody2d.constraints = RigidbodyConstraints2D.FreezeAll;
    }
    public void OnTryButtonClick()
    {
        MainMenu.inst.Onreset();
        UIManager.inst.ShowNextScreen(ScreenEnum.GamePlay);
        Audio.inst.SoundPlay(Audio.SoundName.Try);
        Ball.inst.ball.SetActive(true);
        Ball.inst.spriterenderer.enabled = true;
        Ball.inst.rigidbody2d.isKinematic = false;
        Ball.inst.rigidbody2d.constraints = RigidbodyConstraints2D.FreezeAll;
    }
}
