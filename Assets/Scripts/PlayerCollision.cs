using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public Transform[] Levelskipositions;
    public GameObject Bubble;
    public Animator A_Bubble;
    public CameraControl CameraCon;
    private int currentlevel = 1;
    private bool mute = true;

    private void Update()
    {
        //Want it to mute on default for builds
        if(mute == true)
        {
            AudioListener.volume = 0;
        }
        currentlevel = CameraCon.level;
        if (Input.GetKeyDown(KeyCode.Period))
        {
            currentlevel += 1;
            if (currentlevel > Levelskipositions.Length)
            {
                currentlevel -= 1;
            }
            transform.position = Levelskipositions[currentlevel - 1].transform.position;
        }
        if (Input.GetKeyDown(KeyCode.Comma))
        {
            currentlevel -= 1;
            if(currentlevel < 1)
            {
                currentlevel += 1;
            }
            transform.position = Levelskipositions[currentlevel - 1].transform.position;
        }
        if (Input.GetKeyDown(KeyCode.M))
        {
            mute = !mute;
            if(mute == true)
            {
                AudioListener.volume = 0;
            }
            if(mute == false)
            {
                AudioListener.volume = 1;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject == Bubble)
        {
            A_Bubble.SetBool("GetBubble", true);
        }
    }
}