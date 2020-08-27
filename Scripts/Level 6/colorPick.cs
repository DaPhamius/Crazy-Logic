using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorPick : MonoBehaviour
{
    public bool isRedTouching;
    public bool isYellowTouching;
    public quizManager questManager;
    public correctAnswer cA;
    void Start()
    {
        isYellowTouching = false;
        isRedTouching = false;
    }

    public void click()
    {
        if (isYellowTouching)
        {
            questManager.CorrectAnswer();
            cA.correctAnswerMethod();

        }

        if (!isYellowTouching && isRedTouching)
        {
            questManager.WrongAnswer();
        }
    }


    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("triggered");
        if (col.gameObject.CompareTag("Yellow"))
        {
            isYellowTouching = true;
        }

        if (col.gameObject.CompareTag("Red"))
        {
            isRedTouching = true;
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Yellow"))
        {
            isYellowTouching = false;
        }

        if (col.gameObject.CompareTag("Red"))
        {
            isRedTouching = false;
        }
    }


}
