using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DNDOrder : MonoBehaviour
{
    int currentEvent = 0;
    public void startEvent()
    {
        this.transform.GetChild(currentEvent).gameObject.SetActive(true);
        currentEvent++;
    }


    // Start is called before the first frame update
    void Start()
    {
        this.transform.GetChild(0).gameObject.SetActive(false);
        this.transform.GetChild(1).gameObject.SetActive(false);
        this.transform.GetChild(2).gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
