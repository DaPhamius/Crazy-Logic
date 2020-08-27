using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindDifferences : MonoBehaviour
{
    public bool first = false;
    public bool second = false;
    public bool third = false;
    public bool fourth = false;
    public bool fifth = false;
    public GameObject firstCircle;
    public GameObject secondCircle;
    public GameObject thirdCircle;
    public GameObject fourthCircle;
    public GameObject fifthCircle;
    public quizManager qM;
    public GameObject success;
    public GameObject correct;
    public bool gameCompleted = false;

    private void Update()
    {
        if (first && second && third && fourth && fifth && !gameCompleted)
        {
            StartCoroutine(userPickCorrect());
        }
    }

    public void firstClue()
    {
        if (!first)
        {
            firstCircle.SetActive(true);
            first = true;
        }
    }

    public void secondClue()
    {
        if (!second)
        {
            secondCircle.SetActive(true);
            second = true;
        }
    }

    public void thirdClue()
    {
        if (!third)
        {
            thirdCircle.SetActive(true);
            third = true;
        }

    }

    public void fourthClue()
    {
        if (!fourth)
        {
            fourthCircle.SetActive(true);
            fourth = true;
        }
    }

    public void fifthClue()
    {
        if (!fifth)
        {
            fifthCircle.SetActive(true);
            fifth = true;
        }
    }

    public IEnumerator userPickCorrect()
    {
        gameCompleted = true;
        qM.CorrectAnswer();
        correct.transform.gameObject.SetActive(true);
        yield return new WaitForSeconds(2.5f);
        success.SetActive(true);
        yield return new WaitForSeconds(1.5f);
    }
}
