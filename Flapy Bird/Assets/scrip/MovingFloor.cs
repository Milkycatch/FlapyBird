using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MovingFloor : MonoBehaviour
{

    private Rigidbody2D rb2d;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent <Rigidbody2D> ();
        rb2d.velocity = new Vector2(GamesControls.instance.scrollspeed, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (GamesControls.instance.gameOver == true)
        {
            rb2d.velocity =Vector2.zero;
        }
    }
}
