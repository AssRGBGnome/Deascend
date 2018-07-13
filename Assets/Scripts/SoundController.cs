using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    public AudioSource JumpAudiorend;
    public AudioSource Ascendrend;
    public AudioClip[] Jumpsounds;
    public AudioClip Ascendsound;
    public AudioClip Descendsound;
    public PlatformerCharacter2D Platchar;
    public Ascender ascender;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && Platchar.m_Grounded == true)
        {
            int j = Random.Range(0, Jumpsounds.Length);
            JumpAudiorend.clip = Jumpsounds[j];
            JumpAudiorend.PlayOneShot(Jumpsounds[j], 0.5f);
            Debug.Log(j);
        }
    }

    public void PlayAscendSound()
    {
        Ascendrend.clip = Ascendsound;
        Ascendrend.Play();
    }
    public void PlayDescendSound()
    {
        Ascendrend.clip = Descendsound;
        Ascendrend.Play();
    }
}