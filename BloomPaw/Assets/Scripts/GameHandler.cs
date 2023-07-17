using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameHandler : MonoBehaviour
{

    
    [SerializeField] PointCounter pointCounter; //Singelton
    [SerializeField] HighscoreHandler HighscoreHandler;
    [SerializeField] PointHUD pointHUD;
    //[SerializeField] InputField playerName;
    public void StartGame() {
        pointCounter.StartGame();
    }

    

    public void StopGame() {
       // HighscoreHandler.SetHighscoreIfGreater(pointHUD.Points);
        HighscoreHandler.AddHighscoreIfPossible(new InputEntry(PlayerPrefs.GetString("name"), pointHUD.Points));
        pointCounter.StopGame();

    }
}
