using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "InventoryItem", menuName = "FlowerData")]
public class InventoryItem : ScriptableObject{
    public int flowerCount = 3;

    public void addCount(){
        flowerCount++;
    }

    public void decreaseCount(){
        flowerCount--;
    }

}