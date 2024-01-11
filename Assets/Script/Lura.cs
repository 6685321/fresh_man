using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Lura : MonoBehaviour
{
    public GameObject image;
    public Sprite pagetwo;
    public Sprite pagethree;
    public Sprite pagefour;
    public GameObject quite;

    // Start is called before the first frame update
    void Start()
    {

    }

    int changeIndex = 1;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && changeIndex == 1)
        {
            Change1To2();
            changeIndex = 2;
            return;
        }
        if (Input.GetKeyDown(KeyCode.Space) && changeIndex == 2)
        {
            Change2To3();
            changeIndex = 3;
            return;
        }
        if (Input.GetKeyDown(KeyCode.Space) && changeIndex == 3)
        {
            Change3To4();
            changeIndex = 4;
            return;
        }

        if (Input.GetKeyDown(KeyCode.Space) && changeIndex == 4)
        {
            quite.SetActive(true);
        }

    }
    void Change1To2()
    {
        image.GetComponent<Image>().sprite = pagetwo;
    }
    void Change2To3()
    {
        image.GetComponent<Image>().sprite = pagethree;
    }
    void Change3To4()
    {
        image.GetComponent<Image>().sprite = pagefour;
    }
}
