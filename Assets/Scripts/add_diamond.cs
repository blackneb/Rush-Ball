using UnityEngine;
using UnityEngine.UI;

public class add_diamond : MonoBehaviour
{

    public Text diamond_number;
    public int number;
    public void Diamond_UP()
    {
        number += 10;
        diamond_number.text = number.ToString("0");
        PlayerPrefs.SetInt("Diamond", number);
        //FindObjectOfType<game_manager>().number = number;
    }

}
