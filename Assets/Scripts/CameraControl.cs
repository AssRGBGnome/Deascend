using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public Animator CamAnim;
    public GameObject Player;
    private Vector3 _Player;
    public int level = 1;

    private void Update()
    {
        _Player = Player.transform.position;
        CameraChange();
    }

    private void CameraChange()
    {
        if (_Player.x >= -106.2 && _Player.x <= -35.6 && _Player.y >= -20 && _Player.y <= 20)
        {
            Debug.Log("Farts and stuff are cool tyo! You in 0.");
            CamAnim.SetInteger("Level", 0);
            level = 0;
        }
        if (_Player.x >= -35.6 && _Player.x <= 35.6 && _Player.y >= -20 && _Player.y <= 20)
        {
            Debug.Log("Farts and stuff are cool tyo! You in 1.");
            CamAnim.SetInteger("Level", 1);
            level = 1;
        }
        else if(_Player.x >= 35.6 && _Player.x <= 106.7 && _Player.y >= -20 && _Player.y <= 20)
        {
            Debug.Log("Farts and stuff are cool tyo! You in 2.");
            CamAnim.SetInteger("Level", 2);
            level = 2;
        }
        else if(_Player.x >= 106.7 && _Player.x <= 177.8 && _Player.y >= -20 && _Player.y <= 20)
        {
            Debug.Log("Farts and stuff are cool tyo! You in 3.");
            CamAnim.SetInteger("Level", 3);
            level = 3;
        }
    }
}