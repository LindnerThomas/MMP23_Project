using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryHandler : MonoBehaviour
{
    [SerializeField] InventoryItem inventoryItem;
    [SerializeField] Text textInventoryItem;

    public bool activeMethod = false;
    
    public bool ActiveMethod{
        get {
            return activeMethod;
        }

        set {
            activeMethod = value;
        }
    }
  

  
    // Update is called once per frame
    void Update()
    {
        textInventoryItem.text = inventoryItem.flowerCount.ToString();
    }

    public void addCount(){
        inventoryItem.flowerCount++;
        activeMethod = true;
   
    }    

    public void decreaseCount(){
        inventoryItem.flowerCount--;
        activeMethod = true;
    }

    public void setCountDefault(){
        inventoryItem.flowerCount = 3;
    }


}
