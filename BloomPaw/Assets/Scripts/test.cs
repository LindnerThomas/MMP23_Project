using UnityEngine;
using System.Collections;

public class ExampleClass : MonoBehaviour
{
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Vector3 mousePos = Input.mousePosition;
            {
                //Debug.Log(mousePos.x);
                //Debug.Log(mousePos.y);
            }
        }
    }
}