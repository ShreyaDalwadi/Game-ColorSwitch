using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    public float time;
    public float camPosy;
    Vector3 PlayerPos;

    void CameraStartPoint()
    {
        PlayerPos = new Vector3(player.transform.position.x, player.transform.position.y + camPosy, -10);
        transform.position = Vector3.Lerp(transform.position, PlayerPos, time * Time.deltaTime);

        float diff = Vector2.Distance(transform.position, player.transform.position);
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