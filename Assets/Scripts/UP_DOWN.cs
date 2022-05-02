using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UP_DOWN : MonoBehaviour
{
    float sliding_force = 0.03f;
    Vector3 pos;
    bool position = true;
    void FixedUpdate()
    {
        if (transform.position.y == 3.0f)
        {
            position = false;
        }
        else if (transform.position.y == 1.0f)
        {
            position = true;
        }
        if (transform.position.y >= 1.0f  && transform.position.y <= 3.0f)
        {
            if(position == true)
            {
                transform.position += new Vector3(0, sliding_force, 0);
            }
            else if(position == false)
            {
                transform.position += new Vector3(0, -sliding_force, 0);
            }
        }
        else
        {
            pos = transform.position;
            if (position == true)
            {
                pos[1] = 3.0f;
            }
            else
            {
                pos[1] = 1.0f;
            }
            transform.position = pos;
        }

    }
}
