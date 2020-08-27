using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    public Animator carAnim;
    public GameObject success, correct, wrong;
    public quizManager qM;
    public isTextTouching iTT;


    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            carAnim.Play("CarIdle");
        }
    }



    public void Drive()
    {
        if (iTT.isTouching)
        {
            StartCoroutine(userPickCorrect());
        }

        if (!iTT.isTouching)
        {
            StartCoroutine(userPickWrong());
        }
    }

    public IEnumerator userPickCorrect()
    {
        carAnim.Play("CarWin");
        yield return new WaitForSeconds(1);
        qM.CorrectAnswer();
        correct.transform.gameObject.SetActive(true);
        yield return new WaitForSeconds(2.5f);
        success.SetActive(true);
        yield return new WaitForSeconds(1.5f);
    }

    public IEnumerator userPickWrong()
    {
        carAnim.Play("CarDrop");
        yield return new WaitForSeconds(1);
        qM.WrongAnswer();

        wrong.transform.gameObject.SetActive(true);
        yield return new WaitForSeconds(2.5f);
        wrong.transform.gameObject.SetActive(false);
        carAnim.Play("CarIdle");

    }
}

