using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Quiz Question", fileName = "New Question")]                         
public class QuestionSO : ScriptableObject
{
    [TextArea(2,6)]
    [SerializeField] string Question = "Enter the new question here.";
    [SerializeField] string[] answers = new string[4];
    [SerializeField] int correctAnswerIndex;

    public string getQuestion()
    {
            return Question;
    }

    public int getCorrectAnswerIndex()
    {
        return correctAnswerIndex;
    } 

    public  string getAnswer (int index)
    {
        return answers[index];
    }
}
