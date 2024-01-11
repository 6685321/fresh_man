using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class d2: MonoBehaviour
{
    //綠色

    [Header("UI組件")]
    public Text textLabel;
    public Image faceImage;

    [Header("文本文件")]
    public TextAsset textFile;
    public int index;
    public float textSpeed;

    [Header("頭像")]
    public Sprite face01;

    bool textFinished;//是否完成打字
    bool cancelTyping;//取消打字

    List<string> textList = new List<string>();
    // Start is called before the first frame update
    void Awake()
    {
        GetTextFormFile(textFile);
    }
    private void OnEnable()
    {
        //textLabel.text = textList[index];
        //index++;
        textFinished = true;
        StartCoroutine(SetTextUI());
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && index == textList.Count)
        {
            gameObject.SetActive(false);
            index = 0;
             SceneManager.LoadScene(2);
            return;
           
        }
        //if (Input.GetKeyDown(KeyCode.Space) && textFinished)
        //{
        //textLabel.text = textList[index];
        //index++;
        //    StartCoroutine(SetTextUI());
        //}

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (textFinished && !cancelTyping)
            {
                StartCoroutine(SetTextUI());
            }
            else if (!textFinished)
            {
                cancelTyping = !cancelTyping;
            }
        }

    }

    void GetTextFormFile(TextAsset file)
    {
        textList.Clear();
        index = 0;

        var LineDate = file.text.Split('\n');

        foreach (var Line in LineDate)
        {
            textList.Add(Line);
        }
    }

    IEnumerator SetTextUI()
    {
        textFinished = false;
        textLabel.text = "";

        switch (textList[index])
        {
            case "A":
                faceImage.sprite = face01;
                index++;
                break;
        }

        //for (int i = 0; i < textList[index].Length; i++)
        //{
        //    textLabel.text += textList[index][i];

        //    yield return new WaitForSeconds(textSpeed);
        //}
        int letter = 0;
        while (!cancelTyping && letter < textList[index].Length - 1)
        {
            textLabel.text += textList[index][letter];
            letter++;
            yield return new WaitForSeconds(textSpeed);
        }
        textLabel.text = textList[index];
        cancelTyping = false;
        textFinished = true;
        index++;
    }
    public void GoToGameScene()
    {

    }
}
