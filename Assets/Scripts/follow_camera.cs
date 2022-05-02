using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow_camera : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;
    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 pos = player.position;
        pos[0] = 0;
        transform.position = pos + offset;
    }
}
