using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindPeople : MonoBehaviour
{
    public bool first = false;
    public bool second = false;
    public bool third = false;
    public bool fourth = false;
    public bool fifth = false;
    public bool sixth = false;
    public bool seventh = false;
    public bool eighth = false;
    public bool nineth = false;
    public GameObject firstCircle;
    public GameObject secondCircle;
    public GameObject thirdCircle;
    public GameObject fourthCircle;
    public GameObject fifthCircle;
    public GameObject sixthCircle;
    public GameObject seventhCircle;
    public GameObject eighthCircle;
    public GameObject ninethCircle;


    public quizManager qM;
    public GameObject success;
    public GameObject correct;
    public bool gameCompleted = false;

    private void Update()
    {
        if (first && second && third && fourth && fifth && sixth && seventh && eighth && nineth && !gameCompleted)
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

    public void sixthClue()
    {
        if (!sixth)
        {
            sixthCircle.SetActive(true);
            sixth = true;
        }
    }
    public void seventhClue()
    {
        if (!seventh)
        {
            seventhCircle.SetActive(true);
            seventh = true;
        }
    }
    public void eighthClue()
    {
        if (!eighth)
        {
            eighthCircle.SetActive(true);
            eighth = true;
        }
    }
    public void ninethClue()
    {
        if (!nineth)
        {
            ninethCircle.SetActive(true);
            nineth = true;
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
