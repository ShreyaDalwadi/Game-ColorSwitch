using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScreen : screen
{
    public void OnPlayButtonClick()
    {
        UIManager.inst.ShowNextScreen(ScreenEnum.GamePlay);
        MainMenu.inst.ball.SetActive(true);
        MainMenu.inst.SetObjectsActive();


    }
    public void OnHomeeButtonClick()
    {
        UIManager.inst.ShowNextScreen(ScreenEnum.MainMenu);

    }
}
