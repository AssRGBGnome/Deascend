using System;
using UnityEngine;

public class PlatformerCharacter2D : MonoBehaviour
{
    [SerializeField] public float m_MaxSpeed = 10f;
    [SerializeField] public float m_JumpForce = 900f;
    [SerializeField] private bool m_AirControl = false;
    [SerializeField] private LayerMask m_WhatIsGround;
    public Transform m_GroundCheck;
    public Transform m_CeilingCheck;
    public Rigidbody2D m_Rigidbody2D;
    public bool m_Grounded;
    private bool m_FacingRight = true;
    const float k_GroundedRadius = .2f;
    const float k_CeilingRadius = .01f;
    public float lowjumpmultiplier;

    private void FixedUpdate()
    {
        m_Grounded = false;
        Collider2D[] colliders = Physics2D.OverlapCircleAll(m_GroundCheck.position, k_GroundedRadius, m_WhatIsGround);
        for (int i = 0; i < colliders.Length; i++)
        {
            if (colliders[i].gameObject != gameObject)
            m_Grounded = true;
        }
        if (m_Rigidbody2D.velocity.y > 0 && !Input.GetButton("Jump"))
        {
            m_Rigidbody2D.AddForce(new Vector2(0f, m_JumpForce *-(lowjumpmultiplier) * Time.deltaTime));
        }
    }

    public void Move(float move, bool jump)
    {
        if (m_Grounded || m_AirControl)
        {
            m_Rigidbody2D.velocity = new Vector2(move * m_MaxSpeed, m_Rigidbody2D.velocity.y);
            if (move > 0 && !m_FacingRight) { Flip(); }
            else if (move < 0 && m_FacingRight) { Flip(); }
        }
        if (m_Grounded && jump)
        {
            m_Grounded = false;
            m_Rigidbody2D.AddForce(new Vector2(0f, m_JumpForce));
        }
    }

    private void Flip()
    {
        m_FacingRight = !m_FacingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
}
