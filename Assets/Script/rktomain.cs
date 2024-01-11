using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Rktomain : MonoBehaviour
{
    // Start is called before the first frame update
   void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space ))
        {
            SceneManager.LoadScene(0);
        }
    }
    // Update is called once per frame

   
}
