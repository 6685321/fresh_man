using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{

    private BoxCollider2D boxCollider;
    private Vector3 moveDelta;
    private RaycastHit2D hit;


    public Sprite player_up, player_down, player_left, player_right;


    // Start is called before the first frame update
    void Start()
    {
        boxCollider = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.UpArrow))
        {
            //Debug.Log("往上走");
            transform.position = new Vector3(transform.position.x, transform.position.y + 0.01f);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            //Debug.Log("往下走");
            transform.position = new Vector3(transform.position.x, transform.position.y - 0.01f);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //Debug.Log("往左走");
            transform.position = new Vector3(transform.position.x - 0.01f, transform.position.y);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            //Debug.Log("往右走");
            transform.position = new Vector3(transform.position.x + 0.01f, transform.position.y);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = player_up;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = player_down;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = player_left;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = player_right;
        }
    }
}
