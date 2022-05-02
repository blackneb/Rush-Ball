using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class create_level : MonoBehaviour
{
    public GameObject[] cube_enemy;
    public GameObject end;
    List<GameObject> cloned_to_destroy;
    List<GameObject> side_cloned;
    public GameObject timed_obstacle;
    public GameObject diamond;
    public Transform ball;
    int random_number = 0;
    int number_of_obstacles = 0;
    int diamond_creation = 0;
    int again = 0;
    int ran = 0;
    int counter = 0;
    int timed_again = 0;
    int space = 20;


    public Transform one;
    public Transform two;
    public Transform three;

    Vector3 poss;
    Vector3 pos;
    Vector3 side_pos;
    Vector3 posit;
    // Start is called before the first frame update
    void Awake()
    {
        posit = new Vector3(0, 0, 0);
        cloned_to_destroy = new List<GameObject>();
        cube_enemy = Resources.LoadAll<GameObject>("Prefabs");
        pos[1] = 0.5f;
        pos[2] = 20f;
        pos[0] = 1.5f;
        random_number = Random.Range(0, 3);
        counter = 0;
        Quaternion spawnRotate = Quaternion.Euler(-90, 0, 0);
        cloned_to_destroy.Add((GameObject)Instantiate(cube_enemy[random_number], pos, spawnRotate));
        while (number_of_obstacles != 40)
        {
            pos[2] += space;
            posit[2] += space;
            random_number = Random.Range(0, 3);
            check_x();
            if (timed_again != 3)
            {
                if (timed_again == 2)
                {
                    space = 20;
                }
                else
                {
                    space = 10;
                }
                cloned_to_destroy.Add((GameObject)Instantiate(cube_enemy[random_number], pos, spawnRotate));
                again_clone();
                create_diamonds();
                again++;        
            }
            if (timed_again == 3)
            {
                int a = Random.Range(0, 2);
                if (a == 0)
                {
                    Instantiate(timed_obstacle, new Vector3(0, 0.75f, pos[2]), transform.rotation);

                }
                else if (a == 1)
                {
                    create_up_down();
                }
                timed_again = 0;
                space = 25;
            }
            timed_again++;
            number_of_obstacles++;
        }
        pos[0] = 0.03f;
        pos[1] = 0.57f;
        pos[2] += 10;
        Instantiate(end, pos, transform.rotation);
    }
    void check_x()
    {
        pos[1] = 0.5f;
        ran = Random.Range(0, 9);
        if (ran == 0 || ran==3 || ran==6)
        {
            pos[0] = -2.3f;
        }
        else if (ran == 1 || ran==4 || ran==7)
        {
            pos[0] = -0.6f;
        }
        else if (ran == 2 || ran==5 || ran==8)
        {
            pos[0] = 1.05f;
        }
    }



    void create_up_down()
    {
        poss[1] = 1.0f;
        poss[2] = pos[2];
        poss[0] = -1.65f;
        Instantiate(one, poss, transform.rotation);
        poss[0] = 0.0f;
        poss[1] = 2.0f;
        Instantiate(two, poss, transform.rotation);
        poss[0] = 1.65f;
        poss[1] = 3.0f;
        Instantiate(three, poss, transform.rotation);
    }



    void create_diamonds()
    {
        Quaternion spawnRotation = Quaternion.Euler(180, 0, 0);
        if (diamond_creation == 3)
        {
            int ran_d = Random.Range(0, 3);
            if (ran_d == 0)
            {
                pos[0] = -1.5f;
            }
            else if (ran_d == 1)
            {
                pos[0] = 0f;
            }
            else if (ran_d == 2)
            {
                pos[0] = 1.5f;
            }
            pos[1] = 0.8f;
            Instantiate(diamond, pos, spawnRotation);
            diamond_creation = 0;
        }
        diamond_creation++;
    }   
    

    public void again_clone()
    {
        if (again == 3)
        {
            int ra = Random.Range(0, 2);
            if (pos[0] == 0)
            {
                if (ra == 0)
                {
                    pos[0] = 1.5f;
                }
                else if (ra == 1)
                {
                    pos[0] = -1.5f;
                }
            }
            else if (pos[0] == 1.5f)
            {
                if (ra == 0)
                {
                    pos[0] = 0f;
                }
                else if (ra == 1)
                {
                    pos[0] = -1.5f;
                }
            }
            else if (pos[0] == -1.5f)
            {
                if (ra == 0)
                {
                    pos[0] = 1.5f;
                }
                else if (ra == 1)
                {
                    pos[0] = 0f;
                }
            }
            cloned_to_destroy[counter++] = Instantiate(cube_enemy[random_number], pos, transform.rotation) as GameObject;
            again = 0;
        }
    }
}
