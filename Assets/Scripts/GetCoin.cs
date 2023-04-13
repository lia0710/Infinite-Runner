using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetCoin : MonoBehaviour
{
    Collider2D myCollider;
    private SpriteRenderer myRenderer;
    public AudioClip myClip;
    public AudioSource mySource;

    void Start()
    {
        myCollider = GetComponent<Collider2D>();
        mySource.clip = myClip;
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        mySource.Play();
        myRenderer = gameObject.GetComponent<SpriteRenderer>();
        myRenderer.enabled = false;
        myCollider.enabled = false;
        GameControlScript.instance.Scored(5);

    }
}
