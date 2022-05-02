using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
    public Transform player;
    public Text scoretext;

    void LateUpdate()
    {
        scoretext.text = player.position.z.ToString("0");
    }

}
