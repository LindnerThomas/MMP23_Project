using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Timer", menuName = "Timer")]
public class Timer : ScriptableObject
{
    
    public float time;

    public void resetTime(){
        time = 600;
    } 
   
}
