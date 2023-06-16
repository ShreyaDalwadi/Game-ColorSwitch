using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Line : MonoBehaviour
{
    public float speed = 30f;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
       rb.velocity = transform.right * speed;
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("linecolide"))
        {

        }
    }
}
