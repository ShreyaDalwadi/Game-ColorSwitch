using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : screen
{
    public void OnHomeButtonClick()
    {
        UIManager.inst.ShowNextScreen(ScreenEnum.MainMenu);
    }
}
