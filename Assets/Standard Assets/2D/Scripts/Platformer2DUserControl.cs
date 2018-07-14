using System;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.SceneManagement;

public class Platformer2DUserControl : MonoBehaviour
{
    public PlatformerCharacter2D m_Character;
    private bool m_Jump;
    public float nonmovejumpforce;

    private void Update()
    {
        if (!m_Jump)
        {
            float h = CrossPlatformInputManager.GetAxisRaw("Horizontal");
            m_Jump = CrossPlatformInputManager.GetButtonDown("Jump"); 
            if (Input.GetKey(KeyCode.R))
            {
                SceneManager.LoadScene(0);
            }
            if (!Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.D) && h != 1 && h != -1)
            {
                m_Character.m_JumpForce = nonmovejumpforce;
            }
            else if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.D) && h >= 1)
            {
                m_Character.m_JumpForce = 12000;
            } //8000
            else { m_Character.m_JumpForce = 12000; } //8000
        }
    }

    private void FixedUpdate()
    {
        float h = CrossPlatformInputManager.GetAxisRaw("Horizontal");
        m_Character.Move(h, m_Jump);
        m_Jump = false;
    }
}