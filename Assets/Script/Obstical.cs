using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstical : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.gameObject.CompareTag("spawnobs");
        //ObjectPooling.inst.SpwanList.Remove(ObjectPooling.inst.random);
    }
}
