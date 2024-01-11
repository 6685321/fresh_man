using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class icononetwo : MonoBehaviour
{
    public GameObject image;
    public Sprite one;
    public Sprite two;
    public Sprite three;
    public Sprite four;




    private int pic;
    // Start is called before the first frame update
    void Start()
    {
        pic = ChangeSample.num;
    }

    // Update is called once per frame
    void Update()
    {

        if (pic == 1)
        {
            ChangeZeroToFirst();
        }
        else if (pic == 2) {
            ChangeToSecond();
        }
        else if (pic == 3)
        {
            ChangeToThird();
        }
        else if (pic == 4)
        {
            ChangeToForth();
        }
    }
    void ChangeZeroToFirst()
    {
        image.GetComponent<Image>().sprite = one;
    }

    void ChangeToSecond()
    {
        image.GetComponent<Image>().sprite = two;
    }

    void ChangeToThird()
    {
        image.GetComponent<Image>().sprite = three ;
    }

    void ChangeToForth()
    {
        image.GetComponent<Image>().sprite = four ;
    }
}
