using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XInputDotNetPure;

public class Ascender : MonoBehaviour
{
    public CameraControl CamrController;
    public SoundController SoundC;
    public Animator Ascend1;
    public Animator Ascend2;
    public Animator Ascend3;
    public float ascendrumble = 2f;
    public float descendrumble = .5f;
    public int level = 1;
    public int floor = 1;
    private bool rumbleascend = false, rumbledescend = false;

    private void Update()
    {
        level = CamrController.level;
        if (level == 1)
        {
            if (Input.GetButton("Descend") && floor != 2)
            {
                floor = 2;
                Ascend1.SetInteger("floor", 2);
                SoundC.PlayAscendSound();
                rumbleascend = true;
                ascendrumble = 2;
            }
            if (Input.GetButton("Ascend") && floor != 1)
            {
                floor = 1;
                Ascend1.SetInteger("floor", 1);
                SoundC.PlayDescendSound();
                rumbledescend = true;
                descendrumble = .5f;
            }
        }
        if(level == 2)
        {
            if (Input.GetButton("Descend") && floor != 2)
            {
                floor = 2;
                Ascend2.SetInteger("floor", 2);
                SoundC.PlayAscendSound();
                rumbleascend = true;
                ascendrumble = 2;
            }
            if (Input.GetButton("Ascend") && floor != 1)
            {
                floor = 1;
                Ascend2.SetInteger("floor", 1);
                rumbledescend = true;
                descendrumble = .5f;
            }
        }
        if (level == 3)
        {
            if (Input.GetButton("Descend") && floor != 2)
            {
                floor = 2;
                Ascend3.SetInteger("floor", 2);
                SoundC.PlayAscendSound();
                rumbleascend = true;
                ascendrumble = 2;
            }
            if (Input.GetButton("Ascend") && floor != 1)
            {
                floor = 1;
                Ascend3.SetInteger("floor", 1);
                SoundC.PlayDescendSound();
                rumbledescend = true;
                descendrumble = .5f;
            }
        }

        if (rumbleascend == true)
        {
            descendrumble = .5f;
            ascendrumble -= Time.deltaTime;
            if (ascendrumble > 0)
            {
                GamePad.SetVibration(PlayerIndex.One, .5f, .5f);
            }
            else { ascendrumble = 2f; GamePad.SetVibration(PlayerIndex.One, 0f, 0f); rumbleascend = false; }
        }
        if (rumbledescend == true)
        {
            ascendrumble = 0f;
            descendrumble -= Time.deltaTime;
            if (descendrumble > 0)
            {
                GamePad.SetVibration(PlayerIndex.One, 1f, 0f);
            }
            else { descendrumble = .5f; GamePad.SetVibration(PlayerIndex.One, 0f, 0f); rumbledescend = false; }
        }
    }
}