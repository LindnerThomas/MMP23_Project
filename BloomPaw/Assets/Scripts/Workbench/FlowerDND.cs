using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;
using UnityEngine.UI;
using TMPro;
using Unity.Burst.CompilerServices;


public class FlowerDND : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    bool dragged = false;
    Vector2 oldPosition;
    int layerMask = 1 << 5;
    public DNDOrder order;
    public int flowerID;
    public Sprite[] flowerSprite;

    public void OnPointerDown(PointerEventData eventData)
    {
        int clickID = eventData.pointerId;

        if (dragged == false)
        {
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
    }
    
    
    
    // OnPointerUp (implemented by IPointerUpHandler) is called when a Mousebutton is released.
    // When Mouse is released => check if a Collider is Hit. 
    public void OnPointerUp(PointerEventData eventData)
    {
        print("ponterup");
        dragged = false;
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.zero, Mathf.Infinity, layerMask);
        CheckCollision(hit);
        StillMode();
    }

    // If Hit => Check target, react accordingly.
    void CheckCollision(RaycastHit2D hit) 
    {
        if (hit.collider != null)
        {
            Debug.Log("hit:" + hit.collider.name);
            if (hit.collider.name == "Circle1")
            {
                GameObject flower = GameObject.Find("Flower1");

                foreach (Transform child in flower.transform)
                {
                    child.GetComponent<SpriteRenderer>().sprite = flowerSprite[flowerID - 1];
                }
            }
            if (hit.collider.name == "Circle2")
            {
                GameObject flower = GameObject.Find("Flower2");

                foreach (Transform child in flower.transform)
                {
                    child.GetComponent<SpriteRenderer>().sprite = flowerSprite[flowerID - 1];
                }
            }
            if (hit.collider.name == "Circle3")
            {
                GameObject flower = GameObject.Find("Flower3");

                foreach (Transform child in flower.transform)
                {
                    child.GetComponent<SpriteRenderer>().sprite = flowerSprite[flowerID - 1];
                }
            }
            order.startEvent();

        }
    }
    
    // simple Drag and Drop Loop
    void CheckforDragging()
    {
        if (dragged)    {DraggedMode();}
        else            {StillMode();}
    }
    
    // Transformation of object while dragged
    void DraggedMode()
    {
        print("x: "+Input.mousePosition.x / GetComponentInParent<Canvas>().scaleFactor + " y: " + Input.mousePosition.y / GetComponentInParent<Canvas>().scaleFactor);
        this.transform.localPosition = new Vector2(Input.mousePosition.x / GetComponentInParent<Canvas>().scaleFactor - 120, Input.mousePosition.y / GetComponentInParent<Canvas>().scaleFactor );
        this.transform.localScale = (new Vector2 (1,1) / 7 * 6);
    }

    // Default transformation before drag
    void StillMode() 
    {
        this.transform.localPosition = oldPosition;
        this.transform.localScale = (new Vector2(1, 1));
    }

    
    
    // Start is called before the first frame update
    void Awake()
    {
        oldPosition = transform.localPosition;
        print(oldPosition);
    }


    // Update is called once per frame
    void Update()
    {
        CheckforDragging();
    }

}
