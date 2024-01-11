using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class talkstop : MonoBehaviour
{
    public GameObject[] talkBars;
    public PlayerMovement player;

    private bool talkingTest()
    {
        for (int i = 0; i < talkBars.Length; i++)
        {
            if (talkBars[i].activeSelf == true)
            {
                return true;
            }
        }
        return false;
    }

    void Update()
    {
        if (talkingTest() == false)
        {
            player.tking = false;
        }
        else
        {
            player.tking = true;
        }
    }
}

