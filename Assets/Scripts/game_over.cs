using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class game_over : MonoBehaviour
{
    public GameObject panel;
    public game_manager manager;
    // Start is called before the first frame update
    public void Start_level_again()
    {
        panel.SetActive(true);
        manager.End_Game();
    }
}
