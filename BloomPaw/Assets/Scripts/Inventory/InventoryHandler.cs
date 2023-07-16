using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryHandler : MonoBehaviour
{
    [SerializeField] InventoryItem inventoryItem;
    [SerializeField] Text textInventoryItem;


  
    // Update is called once per frame
    void Update()
    {
        textInventoryItem.text = inventoryItem.flowerCount.ToString();
    }

    public void addCount(){
        inventoryItem.flowerCount++;
    }

    public void decreaseCount(){
        inventoryItem.flowerCount--;
    }

    public void setCountDefault(){
        inventoryItem.flowerCount = 3;
    }
}
