using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowerChanger : MonoBehaviour
{
    // Start is called before the first frame update

    public void changeFlower(Sprite Flower)
    {
        this.GetComponentInChildren<GameObject>().GetComponent<SpriteRenderer>().sprite = Flower;
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }
}
