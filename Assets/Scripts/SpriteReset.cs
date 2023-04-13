using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteReset : MonoBehaviour
{
    private Collider2D myCollider;
    private SpriteRenderer myRenderer;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -20)
        {
            myCollider = GetComponent<Collider2D>();
            myCollider.enabled = true;
            myRenderer = GetComponent<SpriteRenderer>();
            myRenderer.enabled = true;
        }
    }
}
