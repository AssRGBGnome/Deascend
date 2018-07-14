using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubboAnimationController : MonoBehaviour
{
    public Animator BubboAnimator;
    public SoundController SoundC;

    void Fadein()
    {
        BubboAnimator.SetBool("Fadeout", false);
        BubboAnimator.SetBool("Fadein", true);
    }

    void Fadeout()
    {
        BubboAnimator.SetBool("Fadein", false);
        BubboAnimator.SetBool("Fadeout", true);
    }

    void PlayGetSound()
    {
        SoundC.PlayBubboGetSound();
    }

    //void SpawnParticle()
    //{
    //    Instantiate(Particle, transform.position, Quaternion.identity);
    //}
}
