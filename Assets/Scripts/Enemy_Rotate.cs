using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Rotate : MonoBehaviour
{
    public Rigidbody enemy;
    // Start is called before the first frame update
    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Rotate(0, 50 * Time.deltaTime, 0);
    }
}
