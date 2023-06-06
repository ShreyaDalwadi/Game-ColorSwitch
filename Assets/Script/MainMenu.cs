using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu :screen
{

   public  void OnButtonClick()
    {
        UIManager.inst.ShowNextScreen(ScreenEnum.GamePlay);
        Debug.Log("gamplay");
    }
}
