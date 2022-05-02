using UnityEngine;
using UnityEngine.SceneManagement;

public class start : MonoBehaviour
{
  public void Start_Game()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
