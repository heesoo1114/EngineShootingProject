using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static int currentScore;
    public static ScoreManager Instance;
    public Text text; // Score가 표시될 Text

    private void Awake()
    {
        Instance = this;
        currentScore = 0;
    }

    public int Score
    {
        get { return currentScore; }
        set
        {
            currentScore = value;
            text.text = "Score : " + currentScore;
            PlayerPrefs.SetInt("Score", currentScore);
        }
    }
}
