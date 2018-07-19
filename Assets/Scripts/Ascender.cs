using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ascender : MonoBehaviour
{
    public GameObject asdfdsasd;
    public CameraControl CamrController;
    public SoundController SoundC;
    public Animator Ascend1;
    public Animator Ascend2;
    public int level = 1;
    public int floor = 1;

    private void Update()
    {
        level = CamrController.level;
        if (level == 1)
        {
            if (Input.GetKey(KeyCode.E) && floor != 2)
            {
                floor = 2;
                Ascend1.SetInteger("floor", 2);
                SoundC.PlayAscendSound();
                //asdfdsasd.transform.position += new Vector3(0, 5, 0);
            }
            if (Input.GetKey(KeyCode.Q) && floor != 1)
            {
                floor = 1;
                Ascend1.SetInteger("floor", 1);
                SoundC.PlayDescendSound();
                //asdfdsasd.transform.position += new Vector3(0, -5, 0);
            }
        }
        if(level == 2)
        {
            if(Input.GetKey(KeyCode.E) && floor != 2)
            {
                floor = 2;
                Ascend2.SetInteger("floor", 2);
                SoundC.PlayAscendSound();
            }
            if (Input.GetKey(KeyCode.Q) && floor != 1)
            {
                floor = 1;
                Ascend2.SetInteger("floor", 1);
                SoundC.PlayDescendSound();
            }
        }
    }
 }