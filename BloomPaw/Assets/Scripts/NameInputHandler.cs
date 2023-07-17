using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NameInputHandler : MonoBehaviour
{
    [SerializeField] InputField playerName;

    public void SaveName(){
         PlayerPrefs.SetString("name", playerName.text);
    }
}