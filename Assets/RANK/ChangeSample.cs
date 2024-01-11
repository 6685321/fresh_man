using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSample : MonoBehaviour
{
    public  static int num = 0;
    // Start is called before the first frame update
    void Start()
    {

    }
    public void GoToGameScene(int Scenenumber)
    {
        SceneManager.LoadScene(0);
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {

            if (num == 0)
            {
                num += 1;
                GetComponent<textonetwo>();
                GetComponent<icononetwo >();
                SceneManager.LoadScene(0);
            }
            else if (num == 1) {
                num += 1;
                GetComponent<textonetwo>();
                GetComponent<icononetwo>();
                SceneManager.LoadScene(0);
            }
            else if (num == 2)
            {
                num += 1;
                GetComponent<textonetwo>();
                GetComponent<icononetwo>();
                SceneManager.LoadScene(0);
            }
            else if (num == 3)
            {
                num += 1;
                GetComponent<textonetwo>();
                GetComponent<icononetwo>();
                SceneManager.LoadScene(0);
            }
            else if (num == 4)
            {
                GetComponent<textonetwo>();
                GetComponent<icononetwo>();
                SceneManager.LoadScene(0);
            }

        }
    }

}

