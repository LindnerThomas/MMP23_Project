using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBear : MonoBehaviour
{

    //[SerializeField] Transform[] Postions;
    [SerializeField] Transform Postions2;
    [SerializeField] float ObjectSpeed;
    [SerializeField] float SoundSpeed;
    public AudioSource audioSrc;

    //int NextPostIndex;
    //Transform NextPos;
    bool MusicEnds = true;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(_GrassSteps());
        //NextPos = Postions[0];
    }

    private IEnumerator _GrassSteps(){
       
        while(MusicEnds){
            if (transform.position == Postions2.position){
                MusicEnds = false;
            }
            audioSrc.Play();
            yield return new WaitForSeconds(SoundSpeed);
        }
    
    }

  
    // Update is called once per frame
    void Update()
    {
        MoveGameObject();
    }

   /* void MoveGameObject2(){
        if(transform.position == NextPos.position){
            NextPostIndex++;
            if(NextPostIndex >= Postions.Length){
                NextPostIndex = 0;
            };
            NextPos = Postions[NextPostIndex];
        }
        else{
            transform.position = Vector3.MoveTowards(transform.position, NextPos.position,ObjectSpeed * Time.deltaTime);
        }
    }*/

    void MoveGameObject(){
       
            transform.position = Vector3.MoveTowards(transform.position, Postions2.position,ObjectSpeed * Time.deltaTime);
            
    }
}
