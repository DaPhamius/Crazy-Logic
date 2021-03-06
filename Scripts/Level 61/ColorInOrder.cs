﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorInOrder : MonoBehaviour
{
    public firstCollider first;
    public secondCollider second;
    public thirdCollider third;
    public fourthCollider fourth;
    public fifthCollider fifth;
    public sixthCollider sixth;
    public GameObject success, correct;
    public quizManager qM;
    public bool gameCompleted = false;



    void FixedUpdate()
    {
        if (first.firstColor = true && second.secondColor == true && third.thirdColor == true && fourth.fourthColor == true && fifth.fifthColor == true && sixth.sixthColor == true && gameCompleted == false)
        {
            StartCoroutine(userPickCorrect());
        }
    }

    public IEnumerator userPickCorrect()
    {
        gameCompleted = true;
        yield return new WaitForSeconds(1.5f);
        qM.CorrectAnswer();
        correct.transform.gameObject.SetActive(true);
        yield return new WaitForSeconds(2.5f);
        success.SetActive(true);
        yield return new WaitForSeconds(1.5f);
    }
}
