using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomOrder : MonoBehaviour
{
    public Sprite[] flowers;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<SpriteRenderer>().sprite = flowers[Random.Range(0, flowers.Length)];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
