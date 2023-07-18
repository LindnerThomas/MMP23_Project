using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighscoreUI : MonoBehaviour
{
    [SerializeField] Text highscoreText;

    public void SetHighscore(int score) {
        highscoreText.text = score.ToString();
    }
}
