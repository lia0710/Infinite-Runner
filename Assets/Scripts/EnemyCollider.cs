using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollider : MonoBehaviour
{
    Collider2D myCollider;
    private SpriteRenderer myRenderer;

    void Start()
    {
        myCollider = GetComponent<Collider2D>();
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        myRenderer = gameObject.GetComponent<SpriteRenderer>();
        myRenderer.enabled = false;
        myCollider.enabled = false;
        GameControlScript.instance.Damaged();
    }
}
