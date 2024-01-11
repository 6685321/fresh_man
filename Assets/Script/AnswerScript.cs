using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerScript : MonoBehaviour
{
    public bool isCorrect = false;
    public QuizManger quizManger;

    public void Answer()
    {
        if(isCorrect)
        {
            Debug.Log("Correct Answer");
            quizManger.correct();
        }
        else
        {
            Debug.Log("Wrong Answer");
            quizManger.wrong();
        }
    }
}
