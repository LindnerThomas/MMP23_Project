using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CustomerBehavior : MonoBehaviour
{

    public Sprite[] customerSprites;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<SpriteRenderer>().sprite = customerSprites[Random.Range(0, customerSprites.Length)];
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
