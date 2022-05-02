using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class game_manager : MonoBehaviour
{
    public Ball_movement movement;
    public Transform player_ball;
    public GameObject rebounce;
    public GameObject watch_ad;
    public GameObject main;
    public GameObject left;
    public GameObject right;
    bool gamehasended = false;
    bool completelevel = false;
    public float restartdelay = 0f;
    public Rigidbody ball;
    public GameObject completee_level_ui;
    public Text score;
    public Text highscore;
    public Text diamond;
    int diamond_number;
    public int Z_offset = 140;
    public int number;

    void Start()
    {
        highscore.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
        diamond.text = PlayerPrefs.GetInt("Diamond", 0).ToString();
        diamond_number = PlayerPrefs.GetInt("Diamond", 0);
        FindObjectOfType<add_diamond>().number = diamond_number;
    }
    public void End_Game()
    {
        if (gamehasended == false)
        {
            gamehasended = true;
            setting_high_score();
            Destroy(ball);
            Invoke("Restart", restartdelay);
        }       
    }

    public void Complete_Level()
    {
        if (completelevel == false)
        {
            completelevel = true;
            movement.enabled = false;
            ball.velocity = Vector3.zero;
            completee_level_ui.SetActive(true);
            setting_high_score();
        }
        
    }

    void Restart()
    {
        SceneManager.LoadScene("Game");
    }

    public void setting_high_score()
    {
        Vector3 pos = player_ball.transform.position;
        number = (int)pos[2];

        if (number > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", number);
            highscore.text = number.ToString();
        }
    }
    public void break_game_end()
    {
        movement.enabled = false;
        movement.start = false;
        rebounce.SetActive(true);
        watch_ad.SetActive(true);
        main.SetActive(true);
    }
    public void continue_minus()
    {
        if (PlayerPrefs.GetInt("Diamond", 0) > 50) {
            PlayerPrefs.SetInt("Diamond", diamond_number - 50);
            diamond.text = (diamond_number - 50).ToString();
            Vector3 pos = player_ball.transform.position;
            pos[0] = 0.0f;
            pos[1] = 0.85f;
            pos[2] -= 5.0f;
            player_ball.transform.position = pos;
            movement.enabled = true;
            rebounce.SetActive(false);
            watch_ad.SetActive(false);
            main.SetActive(false);
        }
        else
        {
            End_Game();
        }
        
    }
}
