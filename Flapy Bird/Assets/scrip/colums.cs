using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colums : MonoBehaviour
{
    private void OnTriggerEnter2D (Collider2D other)
    {
        if (other.GetComponent<bird>() != null)
        {
           GamesControls.instance.BirdScore();
        }
    }
   
}
