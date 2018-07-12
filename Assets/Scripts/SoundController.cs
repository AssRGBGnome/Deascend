using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    public AudioSource Audiorend;
    public AudioClip[] Jumpsounds;
    public PlatformerCharacter2D Platchar;
    
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && Platchar.m_Grounded == true)
        {
            int j = Random.Range(0, Jumpsounds.Length);
            Audiorend.clip = Jumpsounds[j];
            Audiorend.Play();
            Debug.Log(j);
        }
    }
}