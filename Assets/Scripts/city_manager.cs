using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class city_manager : MonoBehaviour
{
    [SerializeField]
    public GameObject[] citymanager;
    [SerializeField]
    private int Z_offset;
    public Rigidbody ball;
    // Start is called before the first frame update
    void Start()
    {
        /*for (int i = 0; i < citymanager.Length; i++)
        {
            Instantiate(citymanager[i], new Vector3(7.5f, 0.0f, (i * 50f)-10), Quaternion.Euler(0, 90, 0));
            Z_offset += 50;
        }*/
    }
    public void Recycleplatform(GameObject city)
    {
        city.transform.position = new Vector3(7.5f, 0, Z_offset-10.0f);
        Z_offset += 50;
    }
}
