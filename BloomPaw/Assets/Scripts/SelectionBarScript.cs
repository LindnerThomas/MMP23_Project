using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;
using UnityEngine.UI;

public class SelectionBarScript : MonoBehaviour
{

    Button LeftButton;
    Button RightButton;
    Button FinishButton;

    public DNDOrder order;
    // Awake is called once during the lifetime of the script instance before the game starts.
    void Awake()
    {
        instanceButtons();
    }
    private void instanceButtons() 
    {
        Button[] buttons = GetComponentsInChildren<Button>();
        LeftButton = buttons[0];
        LeftButton.onClick.AddListener(delegate { LeftPressed(); });
        FinishButton = buttons[1];
        FinishButton.onClick.AddListener(delegate { FinishPressed(); });
        RightButton = buttons[2];
        RightButton.onClick.AddListener(delegate { RightPressed(); });
    }

    private void FinishPressed()
    {
        MoveSelectionBarUp();
        order.startEvent();
    }

    private void RightPressed()
    {
        throw new NotImplementedException();
    }

    private void LeftPressed()
    {
        throw new NotImplementedException();
    }

    private void MoveSelectionBarUp()
    {
        GameObject SelectionBar = GameObject.Find("SelectionBar");
        SelectionBar.transform.localPosition = new Vector2 (0,1) * 1000;

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
