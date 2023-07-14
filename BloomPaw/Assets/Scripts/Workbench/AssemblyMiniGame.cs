using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;
using Unity.Burst.CompilerServices;
using System.Diagnostics.Tracing;

public class AssemblyMiniGame : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    bool dragged = false;
    Vector2 oldPosition;
    int RangefieldLayerMask = 1 << 7;
    int CheckpointLayerMask = 1 << 6;
    //bool TaskActive = true;
    int StepCounter = 0;
    public GameObject Paper;
    public Sprite[] sprite1;
    public Sprite[] sprite2;
    public GameObject[] Checkpoints;
    public DNDOrder order;

    public void OnPointerDown(PointerEventData eventData)
    {
        int clickID = eventData.pointerId;
        print("hi");

            if (clickID == -1)
            {
                print("Left mouse click registered on: " + name + " " + Input.mousePosition);
                dragged = true;
            }
            else if (clickID == -2)
            {
                Debug.Log("Right mouse click registered on: " + name);
                dragged = true;
            }
        
    }


    // OnPointerUp (implemented by IPointerUpHandler) is called when a Mousebutton is released.
    // When Mouse is released => check if a Collider is Hit. 
    public void OnPointerUp(PointerEventData eventData)
    {
        print("pointerup");
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.zero, Mathf.Infinity);
        CheckCollision(hit);
        StillMode();
    }

    // If Hit => Check target, react accordingly.
    void CheckCollision(RaycastHit2D hit)
    {
        if (hit.collider != null && dragged)
        {
            Debug.Log("hit:" + hit.collider.name);
        }
    }

    // simple Drag and Drop Loop
    void CheckforRange()
    {
        RaycastHit2D Hit = Physics2D.Raycast(transform.position, Vector2.zero, Mathf.Infinity, RangefieldLayerMask);
        if (Hit.collider != null) { DraggedMode(); }
        else
        {
            StillMode();
        }
    }

    void CheckforCheckpoint()
    {
        RaycastHit2D Hit = Physics2D.Raycast(transform.position, Vector2.zero, Mathf.Infinity, CheckpointLayerMask);
        if (Hit.collider != null && StepCounter < sprite1.Length && Hit.collider.name == Checkpoints[StepCounter].name)
        {  
            print("Checkpoint " + StepCounter + " reached");
            Paper.GetComponentsInChildren<SpriteRenderer>()[0].sprite = sprite1[StepCounter];
            Paper.GetComponentsInChildren<SpriteRenderer>()[1].sprite = sprite2[StepCounter];
            StepCounter ++;   
        }

    }

    // Transformation of object while dragged
    void DraggedMode()
    {
        this.transform.localPosition = new Vector2(Input.mousePosition.x / GetComponentInParent<Canvas>().scaleFactor - 120, Input.mousePosition.y / GetComponentInParent<Canvas>().scaleFactor -70);
    }

    // Default transformation before drag
    void StillMode()
    {

        dragged = false;
        transform.localPosition = oldPosition;
    }



    // Start is called before the first frame update
    void Start()
    {
        oldPosition = transform.localPosition;
    }


    // Update is called once per frame
    void Update()
    {
        if (dragged)
        {
            CheckforRange();
            CheckforCheckpoint();
        }
        if (StepCounter == sprite1.Length)
        {
            //TaskActive = false;
            order.startEvent();
        }
    }
}
