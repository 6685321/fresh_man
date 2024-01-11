using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public static float moveSpeed = 30f;

    public Rigidbody2D rb;
    public Animator animator;
    public Transform transforms;

    Vector2 movement;

    public bool tking;
    private void Start()
    {
        transforms = gameObject.GetComponent<Transform>();
        if (PlayerData.x != 0 && PlayerData.y != 0)
        {
            transforms.position = new Vector3(PlayerData.x, PlayerData.y, 0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        PlayerData.x = transforms.position.x;
        PlayerData.y = transforms.position.y;
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


