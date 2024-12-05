using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bird : MonoBehaviour
{
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
            if (Input.GetMouseButtonDown(0))
            {
                 rb2d.velocity = Vector2.zero;
                
            }
        }
    }
}
