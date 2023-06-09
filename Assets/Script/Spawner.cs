using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D collision)
    {
        MainMenu.inst.SetObjectsActive();
        MainMenu.inst.RandomSpwanPoint();

    }
}
