using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public GameObject pointA;
    public GameObject pointB;
    private Rigidbody2D rb;
    public Animator anim;
    private Transform currentPoint;
    [SerializeField]
    private float speed;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        currentPoint = pointB.transform;
        anim.SetBool("isMovingRight", true);
    }

    private void Update()
    {
        /*
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        Vector3 direction = new Vector3(horizontal, vertical);
        anim.SetFloat("horizontal", direction.x);
        anim.SetFloat("vertical", direction.y);
        */
        Vector2 point = currentPoint.position - transform.position;
        if(currentPoint == pointB.transform)
        {
            rb.velocity = new Vector2(speed, 0);
            anim.SetBool("isMovingRight", true);
            anim.SetBool("isMovingLeft", false);
        }
        else
        {
            rb.velocity = new Vector2(-speed, 0);
            anim.SetBool("isMovingLeft", true);
            anim.SetBool("isMovingRight", false);
        }

        if(Vector2.Distance(transform.position, currentPoint.position) < 0.5f
            && (currentPoint == pointB.transform))
        {
            currentPoint = pointA.transform;
        }

        if (Vector2.Distance(transform.position, currentPoint.position) < 0.5f
           && (currentPoint == pointA.transform))
        {
            currentPoint = pointB.transform;
        }
    }
}
