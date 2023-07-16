using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSpritesFlowers : MonoBehaviour
{
    [SerializeField] InventoryItem inventoryItem;
    public Sprite sp1, sp2;


    // Update is called once per frame
    void Update()
    {
         if(inventoryItem.flowerCount <= 0){
            GetComponent<SpriteRenderer>().sprite = sp2;
        }else{
            GetComponent<SpriteRenderer>().sprite = sp1;
        }
    }
}
