using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowerGrowth : MonoBehaviour
{
    Animator anim1;
    private bool entered = false;
    // Start is called before the first frame update
    void Start()
    {
        anim1 = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //Only when player is next to the plant it grows(entered = true)
        if (Input.GetMouseButtonDown(0) && entered && !anim1.GetBool("Growth"))
        {
            anim1.SetTrigger("Growth");
            anim1.ResetTrigger("Pick");
        }
        //We only want to be able to pick if the flower has already grown(animation is finished)
        else if(Input.GetMouseButtonDown(0) && entered && anim1.GetBool("Growth")
            && TestIfAnimationFinished())
        {
            anim1.SetTrigger("Pick");
            anim1.ResetTrigger("Growth");
            //TODO: The flower must be added to the inventory when it is picked
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Player player = collision.GetComponent<Player>();

        if(player)
        {
           entered = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Player player = collision.GetComponent<Player>();

        if (player)
        {
            entered = false;
        }
    }

    //Test if the plant animation is finished, otherwise
    //we could simply pick when the plant has not fully grown yet
    private bool TestIfAnimationFinished()
    {
        AnimatorStateInfo animatorStateInfo = anim1.GetCurrentAnimatorStateInfo(0);
        float Ntime = animatorStateInfo.normalizedTime;

        if(Ntime > 1.0f)
        {
            return true;
        }
        return false;
    }

}
