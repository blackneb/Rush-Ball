using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle_turn : MonoBehaviour
{
    public Rigidbody obstacle;
    float sliding_force = 0.04f;
    bool position = true;
    Vector3 pos;
    void FixedUpdate()
    {
        if (transform.position.x == 1.5f)
        {
            position = false;
        }
        else if (transform.position.x == -1.5f)
        {
            position = true;
        }
        if (transform.position.x >= -1.5f && transform.position.x <= 1.5f)
        {
            if (position == true)
            {
                transform.position += new Vector3(sliding_force, 0, 0);
            }
            else if (position == false)
            {
                transform.position += new Vector3(-sliding_force, 0, 0);
            }

        }
        else
        {
            pos = transform.position;
            if (position == true)
            {
                pos[0] = 1.5f;
            }
            else
            {
                pos[0] = -1.5f;
            }
            transform.position = pos;
        }
    }
}