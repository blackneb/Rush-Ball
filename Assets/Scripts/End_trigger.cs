using UnityEngine;

public class End_trigger : MonoBehaviour
{
    void OnTriggerEnter()
    {
        FindObjectOfType<game_manager>().Complete_Level();
    }
}
