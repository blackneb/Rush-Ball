using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_movement : MonoBehaviour
{
    public Rigidbody ball;
    public Distroy dis;
    public float forward_force = 2000f;
    public float roll_speed = 200f;
    public float slide_force = 5f;
    public float jump = 20f;
    public bool start = false;
    public GameObject wellcome;
    public GameObject score;
    public GameObject tap;
    public GameObject highscore;
    Vector3 pos;
    // Start is called before the first frame updat
    // Update is called once per frame
    void Update()
    {
        if (start == true)
        {
            if (ball.velocity.z < 45f)
            {
                ball.AddForce(0, 0, forward_force * Time.deltaTime);

            }
            ball.transform.Rotate(roll_speed * Time.deltaTime, 0, 0);

            movement();
            //cube.transform.position = pos;
        }
    }
    public void movement()
    {
        pos = ball.transform.position;
        if (Input.GetKeyDown(KeyCode.D))
        {
            pos = ball.transform.position;
            if (start == false)
            {
                set_ball_position();
                start = true;
                wellcome.SetActive(false);
                highscore.SetActive(false);
                tap.SetActive(false);
                score.SetActive(true);
            }
            if (ball.transform.position.x == -1.5f)
            {
                pos[0] = 0.0f;
                ball.transform.position = pos;
            }
            else if (ball.transform.position.x == 0.0f)
            {
                pos[0] = 1.5f;
                ball.transform.position = pos;
            }
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            pos = ball.transform.position;
            if (start == false)
            {
                set_ball_position();
                start = true;
                wellcome.SetActive(false);
                highscore.SetActive(false);
                tap.SetActive(false);
                score.SetActive(true);
            }
            if (ball.transform.position.x == 1.5f)
            {
                pos[0] = 0.0f;
                ball.transform.position = pos;
            }
            else if (ball.transform.position.x == 0.0f)
            {
                pos[0] = -1.5f;
                ball.transform.position = pos;
            }
        }

    }

    public void turn_left()
    {
        pos = ball.transform.position;
        if (start == false)
        {
            set_ball_position();
            start = true;
            wellcome.SetActive(false);
            highscore.SetActive(false);
            tap.SetActive(false);
            score.SetActive(true);
        }
        if (ball.transform.position.x == 1.5f)
        {
            pos[0] = 0.0f;
            ball.transform.position = pos;
        }
        else if (ball.transform.position.x == 0.0f)
        {
            pos[0] = -1.5f;
            ball.transform.position = pos;
        }
    }
    public void turn_right()
    {
        pos = ball.transform.position;
        if (start == false)
        {
            set_ball_position();
            start = true;
            wellcome.SetActive(false);
            highscore.SetActive(false);
            tap.SetActive(false);
            score.SetActive(true);
        }
        if (ball.transform.position.x == -1.5f)
        {
            pos[0] = 0.0f;
            ball.transform.position = pos;
        }
        else if (ball.transform.position.x == 0.0f)
        {
            pos[0] = 1.5f;
            ball.transform.position = pos;
        }
    }
    public void set_ball_position()
    {
        pos[0] = 0;
        pos[1] = 0.85f;
        ball.transform.position = pos;
    }
}
