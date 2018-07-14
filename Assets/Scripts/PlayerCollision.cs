using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public GameObject Bubble;
    public Animator A_Bubble;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject == Bubble)
        {
            A_Bubble.SetBool("GetBubble", true);
        }
    }
}