using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DNDOrder : MonoBehaviour
{
    int currentEvent = 1;
    int flowerID1;
    int flowerID2;
    int flowerID3;

    public void startEvent()
    {
        this.transform.GetChild(currentEvent - 1).gameObject.SetActive(false);
        this.transform.GetChild(currentEvent).gameObject.SetActive(true);
        currentEvent++;
    }


    // Start is called before the first frame update
    void Start()
    {
        foreach (Transform child in this.transform ) 
        {
            child.gameObject.SetActive(false);
        }

        this.transform.GetChild(0).gameObject.SetActive(true);

    }

    public int getEventCounter() 
    { 
        return currentEvent;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
