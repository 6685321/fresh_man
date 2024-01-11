using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MainScript : MonoBehaviour
{
    // Start is called before the first frame update

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Debug.Log("往上走");
            transform.position = new Vector3(transform.position.x, transform.position.y + 0.08f);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            Debug.Log("往下走");
            transform.position = new Vector3(transform.position.x, transform.position.y - 0.08f);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Debug.Log("往左走");
            transform.position = new Vector3(transform.position.x - 0.08f, transform.position.y);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Debug.Log("往右走");
            transform.position = new Vector3(transform.position.x + 0.08f, transform.position.y);
        }
    }
}

