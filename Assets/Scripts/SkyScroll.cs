using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyScroll : MonoBehaviour
{
    private Rigidbody2D rb2d;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();

        rb2d.velocity = new Vector2(-5, 0);
        //GameControlScript.instance.scrollSpeed
    }

    void Update()
    {
        if (GameControlScript.instance.gameOver == true)
        {
            rb2d.velocity = Vector2.zero;
        }
    }
}
