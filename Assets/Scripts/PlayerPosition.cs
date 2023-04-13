using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPosition : MonoBehaviour
{

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 reset = new Vector2(0, transform.position.y);
        transform.position = (Vector2)reset;

        //Vector2 groundOffset = new Vector2(groundHorizontalLength * 2f, 0);
        //transform.position = (Vector2)transform.position + groundOffset;
    }
}
