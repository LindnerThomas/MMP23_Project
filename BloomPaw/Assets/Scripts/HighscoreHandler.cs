using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighscoreHandler : MonoBehaviour
{
    List<InputEntry> highscoreList = new List<InputEntry>();
    [SerializeField] int maxCount = 7;
    [SerializeField] string filename;

    public delegate void OnHighscoreListChanged (List<InputEntry> list);
    public static event OnHighscoreListChanged onHighscoreListChanged;

    private void Start() {
        LoadHighscore();
    }
    private void LoadHighscore() {
        highscoreList= FileHandler.ReadFromJSON<InputEntry>(filename);

        while(highscoreList.Count > maxCount) {
            highscoreList.RemoveAt(maxCount);
        }

        if (onHighscoreListChanged != null){
            onHighscoreListChanged.Invoke(highscoreList);
        }


    }
    private void SaveHighscore() {
        FileHandler.SaveToJSON<InputEntry>(highscoreList, filename);
        
    }
    public void AddHighscoreIfPossible(InputEntry element) {
        for(int i = 0; i < maxCount; i++) {
            if( i >= highscoreList.Count || element.score > highscoreList[i].score){
                highscoreList.Insert(i, element);
                
                while(highscoreList.Count > maxCount) {
                    highscoreList.RemoveAt(maxCount);
                }

                SaveHighscore();
                if (onHighscoreListChanged != null){
                    onHighscoreListChanged.Invoke(highscoreList);
                }
                break;
            }
        }
    }
}