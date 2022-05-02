using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class city : MonoBehaviour
{
    public Transform ball;
    public game_manager manage;
    int pos;
    void FixedUpdate()
    {
        if(transform.position.z < ball.transform.position.z - 50.0f)
        {
            pos = manage.Z_offset;
            transform.position = new Vector3(7.5f, 0, pos);
            manage.Z_offset += 50;
        }
    }
}
