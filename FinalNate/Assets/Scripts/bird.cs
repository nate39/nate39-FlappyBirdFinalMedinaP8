using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bird : MonoBehaviour
{
    public float upForce = 200;

    private bool isDead = false;
    private Rigidbody2D rb2d;
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isDead == false)
        {
            if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))
            {
                 rb2d.velocity = Vector2.zero;
                 rb2d.AddForce 
                   (new Vector2(0, upForce));
            }
        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        isDead = true;
    }
}
