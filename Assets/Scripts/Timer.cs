using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] float timeToCompleteQuestion = 20f;
    [SerializeField] float timeToShowAnswer = 10f;
    float timerValue;
    bool isAnsweringQuestion = true;
    void Update()
    {
        UpdateTimer();
    }

    private void UpdateTimer()
    {
        timerValue -= Time.deltaTime;

        if (isAnsweringQuestion)
        {
            if (timerValue == 0)
            {
                isAnsweringQuestion = false;
                timerValue = timeToShowAnswer;
            }  
        }
        else 
        {
            isAnsweringQuestion = false;
            timerValue = timeToCompleteQuestion;        
        }
    } 
}
