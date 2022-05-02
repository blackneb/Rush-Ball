using UnityEngine;

public class diamond_trigger : MonoBehaviour
{
    void OnTriggerEnter(Collider collide)
    {
        if (collide.tag == "ball")
        {
            FindObjectOfType<add_diamond>().Diamond_UP();
            Destroy(this.gameObject);
        } 
    }
}
