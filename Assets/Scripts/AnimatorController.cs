using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorController : MonoBehaviour
{
    public Animator animator;
    public Animator sprite;
    public PlatformerCharacter2D platchar;
    
    private void Update()
    {
        if (Input.GetAxis("Horizontal") >= .9f || Input.GetAxis("Horizontal") <= -.9f && platchar.m_Grounded == true)
        {
            animator.SetBool("Idle", false);
            animator.SetBool("Walking", true);
            animator.SetBool("Air", false);
        }
        else
        {
            animator.SetBool("Idle", true);
            animator.SetBool("Walking", false);
            animator.SetBool("Air", false);
        }
        if (platchar.m_Grounded == false)
        {
            animator.SetBool("Air", true);
            animator.SetBool("Idle", false);
            animator.SetBool("Walking", false);
        }
        if (Input.GetKey(KeyCode.Space) || (Input.GetButton("Jump")))
        {
            sprite.SetBool("Rolling", true);
        }
        else
        {
            sprite.SetBool("Rolling", false);
        }
    }
}