using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager inst;
    public List<screen> screenList;
    public screen currentScreen;

    public void Awake()
    {
        inst = this;

    }
    public void ShowNextScreen(ScreenEnum ScreenType)
    {
        if (currentScreen != null)
            currentScreen.HideScreen();

        screenList[(int)ScreenType].ShowScreen();
        currentScreen = screenList[(int)ScreenType];


      
    }
}



