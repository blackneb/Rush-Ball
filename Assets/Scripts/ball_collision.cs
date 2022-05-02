using UnityEngine;

public class ball_collision : MonoBehaviour
{
    public Ball_movement movement;
    public Rigidbody ball;
    public GameObject game;
    int counter = 0;

    void OnCollisionEnter(Collision collisioninfo)
    {
        if(collisioninfo.collider.tag == "enemy")
        {
            Destroy(collisioninfo.collider);
            ball.velocity = Vector3.zero;
            if (counter == 0)
            {
                FindObjectOfType<game_manager>().break_game_end();
                counter++;
            }
            else
            {
                movement.enabled = false;
                game.SetActive(true);
            }
        }
    }
}
