using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    public GameObject Camera;
    public float time;
    public float camPosy;
    Vector3 PlayerPos;

    public Action action;


    public void OnStateChanged(GameState gs)
    {
        switch (gs)
        {
            case GameState.MainMenu:
                action -= CameraStartPoint;
                break;
            case GameState.Gameplay:
                action += CameraStartPoint;
                break;
            case GameState.GameOver:
                action -= CameraStartPoint;
                break;
        }
    }
    void CameraStartPoint()
    {
        PlayerPos = new Vector3(player.transform.position.x, player.transform.position.y + camPosy, -10);
        Camera.transform.position = Vector3.Lerp(transform.position, PlayerPos, time * Time.deltaTime);

        float diff = Vector2.Distance(Camera.transform.position, player.transform.position);
        if (diff < 3f)
        {
            time = 4f;
        }
    }

    private void Update()
    { 
        CameraStartPoint();
    }
}