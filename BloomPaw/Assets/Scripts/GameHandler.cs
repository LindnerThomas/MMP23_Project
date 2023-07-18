using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameHandler : MonoBehaviour
{
    [SerializeField] PointCounter pointCounter; //Singelton
    [SerializeField] HighscoreHandler HighscoreHandler;
    [SerializeField] PointHUD pointHUD;
    public void StartGame() {
        pointCounter.StartGame();
    }

    public void StopGame() {
        HighscoreHandler.SetHighscoreIfGreater(pointHUD.Points);
        pointCounter.StopGame();

    }
}
