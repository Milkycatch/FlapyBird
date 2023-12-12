using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ReapetingBackGround : MonoBehaviour
{
    private BoxCollider2D groundCollider;
    private float groundHorizontalLeght;
    // Start is called before the first frame update
    void Start()
    {
        groundCollider = GetComponent<BoxCollider2D>();
        groundHorizontalLeght = groundCollider.size.x;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -groundHorizontalLeght)
        {
            RespositionBackground();
        }
    }
    private void RespositionBackground()
    {
        Vector2 groundoffset = new Vector2(groundHorizontalLeght * 2f,0);
        transform.position = (Vector2)transform.position + groundoffset;
    }
}
