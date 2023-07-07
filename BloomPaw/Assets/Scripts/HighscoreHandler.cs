using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighscoreHandler : MonoBehaviour
{
    [SerializeField] HighscoreUI highscoreUI;

    int highscore;
    
    public int Highscore {
        set {
            highscore = value;
            highscoreUI.SetHighscore(value);
        }
    }

    private void Start() {
        SetLatestHighscore();
    }

    private void SetLatestHighscore() {
        Highscore = PlayerPrefs.GetInt("Highscore", 0);

    }
    private void SaveHighscore(int score) {
        PlayerPrefs.SetInt("Highscore", score);
    }

    public void SetHighscoreIfGreater(int score) {
        if(score > highscore) {
            Highscore = score;
            SaveHighscore(score);
        }
    }
}
