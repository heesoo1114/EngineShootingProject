using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerHP : MonoBehaviour
{
    public int playerHP;
    [SerializeField] private Image[] hearts;

    

    // Start is called before the first frame update
    public void Start()
    {
        UpdateHP();
    }

    public void UpdateHP()
    {

        for(int i = 0; i < hearts.Length; i++)
        {
            if (i < playerHP)
            {
                hearts[i].color = Color.white;
            }
            else if (playerHP <= 0)
            {
                SceneManager.LoadScene("GameOver");
            }
            else
            {
                hearts[i].color = Color.black;
            }
        }
    }

}
