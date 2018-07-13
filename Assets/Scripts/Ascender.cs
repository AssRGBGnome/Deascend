using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ascender : MonoBehaviour
{
    public GameObject asdfdsasd;
    public CameraControl CamrController;
    public SoundController SoundC;
    public Animator Ascend;
    public int floor = 1;

    private void Update()
    {
        if (CamrController.level == 1)
        {
            if (Input.GetKey(KeyCode.E) && floor != 2)
            {
                floor = 2;
                Ascend.SetInteger("floor", 2);
                SoundC.PlayAscendSound();
                //asdfdsasd.transform.position += new Vector3(0, 5, 0);
            }
            if (Input.GetKey(KeyCode.Q) && floor != 1)
            {
                floor = 1;
                Ascend.SetInteger("floor", 1);
                SoundC.PlayDescendSound();
                //asdfdsasd.transform.position += new Vector3(0, -5, 0);
            }
        }
    }
 }