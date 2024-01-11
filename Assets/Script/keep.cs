using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keep : MonoBehaviour
{
    public GameObject py;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(py);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
