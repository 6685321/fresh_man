using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class purple : MonoBehaviour
{
    public GameObject Button;
    public GameObject talkUI;
    public PlayerMovement player;
    public static bool tking = false;

    static int i = 0;
    private void OnTriggerEnter2D(Collider2D other)
    {
        Button.SetActive(true);
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        Button.SetActive(false);
    }

    private void Update()
    {
        if (i < 5)
        {
            if (Button.activeSelf && Input.GetKeyDown(KeyCode.Space))
            {
                talkUI.SetActive(true);
                i += 1;
            }
           
       
        
        }
        
    }
}