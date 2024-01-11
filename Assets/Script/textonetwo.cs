using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textonetwo : MonoBehaviour
{
    private  int sum;
    // Start is called before the first frame update
    void Start()
    {
        sum = ChangeSample.num;
    }

    // Update is called once per frame
    void Update()
    {
           GetComponent<Text>().text = "x " + sum;
    }
}
