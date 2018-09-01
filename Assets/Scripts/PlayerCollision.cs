using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public Transform[] Levelskipositions;
    public Transform[] Checkpointpositions;
    public GameObject[] Bubble;
    public GameObject[] Needle;
    public AudioSource Music;
    public AudioSource[] SFX;
    public Animator[] A_Bubble;
    public Animator Playeranim;
    public Rigidbody2D rbtwod;
    public CameraControl CameraCon;
    private int currentlevel = 1;
    private int currentcheckpoint = 0;
    private bool muteMusic = false;
    private bool muteSFX = false;

    private void Update()
    {
        //to mute on default for builds
        if(muteMusic == true)
        {
            Music.mute = true;
        }
        if(muteSFX == true)
        {
            for (int i = 0; i < SFX.Length; i++)
            {
                SFX[i].mute = true;
            }
        }
        Cursor.visible = false;
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
            muteMusic = !muteMusic;
            if(muteMusic == true)
            {
                Music.mute = true;
            }
            if(muteMusic == false)
            {
                Music.mute = false;
            }
        }
        if (Input.GetKeyDown(KeyCode.N))
        {
            muteSFX = !muteSFX;
            if(muteSFX == true)
            {
                for (int i = 0; i < SFX.Length; i++)
                {
                    SFX[i].mute = true;
                }
            }
            if(muteSFX == false)
            {
                for (int i = 0; i < SFX.Length; i++)
                {
                    SFX[i].mute = false;
                }
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject == Bubble[0])
        {
            A_Bubble[0].SetBool("GetBubble", true);
        }
        if (other.gameObject == Bubble[1])
        {
            A_Bubble[1].SetBool("GetBubble", true);
        }
        if (other.gameObject == Bubble[2])
        {
            A_Bubble[2].SetBool("GetBubble", true);
        }

        if (other.gameObject == Needle[0])
        {
            Debug.Log("You Dead!");
            Playeranim.SetBool("Death", true);
        }
    }

    private void Death()
    {
        if(currentcheckpoint == 0)
        {
            rbtwod.constraints = RigidbodyConstraints2D.None;
            transform.localScale = new Vector3(3, 3, 1);
            transform.position = Checkpointpositions[0].transform.position;
            Playeranim.SetBool("Respawn", true);
            Playeranim.SetBool("Death", false);
            Debug.Log("Safe tyo!");
        }
    }

    private void Freeze()
    {
        Playeranim.SetBool("Respawn", false);
        rbtwod.constraints = RigidbodyConstraints2D.FreezeAll;
    }

    private void StopRespawnAnim()
    {
        Playeranim.SetBool("Respawn", false);
    }
}