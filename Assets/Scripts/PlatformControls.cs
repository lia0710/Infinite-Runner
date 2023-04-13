using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformControls : MonoBehaviour
{
    private BoxCollider2D groundCollider;
    bool grounded = false;
    float groundCheckRadius = 0.2f;
    public Transform groundCheck;
    public LayerMask groundLayer;
    public Rigidbody2D myRB;
    bool falling = false;
    bool rising = false;
    bool jumping = false;
    bool grounding = false;


    void Start()
    {
        groundCollider = GetComponent<BoxCollider2D>();
    }

    void Update()
    {
        if (grounded && Input.GetAxis("Jump") > 0)
        {
            grounded = false;
        }

        grounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);

        if(myRB.velocity.y > 0)
        {
            rising = true;
            falling = false;
        }

        if(rising == true && myRB.velocity.y < 0)
        {
            jumping = true;
        }

        if(myRB.velocity.y < 0)
        {
            falling = true;
            rising = false;
        }

        if(grounded == true && falling == true)
        {
            grounding = true;
        }









        if (jumping == true)
        {
            groundCollider.enabled = true;
            jumping = false;
        }



        if (Input.GetKeyDown("down") || Input.GetKeyDown("s"))
        {
            groundCollider.enabled = false;
        }
        if (rising == true)
        {
            groundCollider.enabled = false;
        }

        
    }

}
