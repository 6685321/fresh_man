using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class QuizManger : MonoBehaviour
{
    public List<QuestionAndAnswers> QnA;
    public GameObject[] options;
    public int currentQuestion;

    public GameObject Quizpanel;
    public GameObject GOPanel;
    public GameObject FFPanel;

    public Text QuestionTxt;
    public Text ScoreTxt;

    int totalQuestions = 0;
    public int score;

    static int a = 1;

    private void Start()
    {
        totalQuestions = QnA.Count;
        GOPanel.SetActive(false);
        FFPanel.SetActive(false);
        generateQuestion();
    }
 
    public void GoToGameScene()
    {
        if (a == 1)
        {
            SceneManager.LoadScene(7);
            a += 1;
        }
        else if (a == 2)
        {
            SceneManager.LoadScene(8);
            a += 1;
        }
        else if (a == 3)
        {
            SceneManager.LoadScene(9);
            a += 1;
        }
        else if (a == 4)
        {
            SceneManager.LoadScene(10);
            a += 1;
        }
        else if (a == 5)
        {
            SceneManager.LoadScene(12);
            a += 1;
        }
        else if (a == 6)
        {
           
        }

    }

    public void retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    void GameOver()
    {
        Quizpanel.SetActive(false);
        ScoreTxt.text = score + "/" + totalQuestions;
        if(score == totalQuestions)
        {
            FFPanel.SetActive(true);
        }
        else
        {
            GOPanel.SetActive(true);
        }
    }

    public void correct()
    {
        score += 1;
        QnA.RemoveAt(currentQuestion);
        generateQuestion();
    }

    public void wrong()
    {
        //when you answer wrong
        QnA.RemoveAt(currentQuestion);
        generateQuestion();
    }

    void SetAnswers()
    {
        for (int i = 0;i < options.Length; i++ )
        {
            options[i].GetComponent<AnswerScript>().isCorrect = false;
            options[i].transform.GetChild(0).GetComponent<Text>().text = QnA[currentQuestion].Answers[i];

            if(QnA[currentQuestion].CorrectAnswer == i+1)
            {
                options[i].GetComponent<AnswerScript>().isCorrect = true;
            }
        }

    }
    void generateQuestion()
    {
        if(QnA.Count > 0)
        {
            currentQuestion = Random.Range(0, QnA.Count);

            QuestionTxt.text = QnA[currentQuestion].Question;
            SetAnswers();
        }
        else
        {
            Debug.Log("Out of Questions");
            GameOver();
        }

        
    }
}
