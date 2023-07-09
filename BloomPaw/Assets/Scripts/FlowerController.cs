using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowerController : MonoBehaviour
{
    private Animator animator;
    private int growthStage = 0;

    void Start()
    {
        animator = GetComponent<Animator>();
        StartCoroutine(GrowFlower());
    }

    IEnumerator GrowFlower()
    {
        while (true)
        {
            yield return new WaitForSeconds(10); // waits 10 seconds before the next growth stage.
            growthStage++;
            animator.SetInteger("growthStage", growthStage);
        }
    }
}

