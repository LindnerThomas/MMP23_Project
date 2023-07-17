using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeSpritesFlowers : MonoBehaviour
{
    [SerializeField] InventoryItem inventoryItem;
    [SerializeField] InventoryHandler inventoryHandler;
    public Sprite sp1, sp2;


    // Update is called once per frame
    void Update()
    {
         if(inventoryHandler.activeMethod && inventoryItem.flowerCount == 0){
            GetComponent<SpriteRenderer>().sprite = sp2;
        }else if(inventoryHandler.activeMethod && inventoryItem.flowerCount == 1) {
            GetComponent<SpriteRenderer>().sprite = sp1;
        }
    }
}

