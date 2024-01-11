using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playsec : MonoBehaviour
{
    public static float moveSpeed = 30f;

    public Rigidbody2D rb;
    public Animator animator;


    Vector2 movement;

    public bool tking;

    // Update is called once per frame
    void Update()
    {

        if (tking == false)
        {
            movement.x = Input.GetAxisRaw("Horizontal");
            movement.y = Input.GetAxisRaw("Vertical");

            animator.SetFloat("Horizontal", movement.x);
            animator.SetFloat("Vertical", movement.y);
            animator.SetFloat("Speed", movement.sqrMagnitude);

            rb.MovePosition(rb.position + movement * moveSpeed * Time.deltaTime);
        }
    }


}
