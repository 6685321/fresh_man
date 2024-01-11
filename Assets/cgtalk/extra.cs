using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class extra : MonoBehaviour
{
    public GameObject sp;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            sp.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            sp.SetActive(false);
        }
    }

}
