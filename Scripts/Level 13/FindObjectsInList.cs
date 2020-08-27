using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class FindObjectsInList : MonoBehaviour
{
    public bool first = false;
    public bool second = false;
    public bool third = false;
    public bool fourth = false;
    public bool fifth = false;
    public bool sixth = false;
    public GameObject firstCircle;
    public GameObject secondCircle;
    public GameObject thirdCircle;
    public GameObject fourthCircle;
    public GameObject fifthCircle;
    public GameObject sixthCircle;
    public Text firstT;
    public Text secondT;
    public Text thirdT;
    public Text fourthT;
    public Text fifthT;
    public Text sixthT;
    public quizManager qM;
    public GameObject success;
    public GameObject correct;
    public bool gameCompleted = false;

    private void Update()
    {
        if (first && second && third && fourth && fifth && sixth && !gameCompleted)
        {
            StartCoroutine(userPickCorrect());
        }
    }

    public void firstClue()
    {
        if (!first)
        {
            firstT.GetComponent<Text>().color = Color.yellow;
            firstCircle.SetActive(true);
            first = true;
        }
    }

    public void secondClue()
    {
        if (!second)
        {
            secondT.GetComponent<Text>().color = Color.yellow;
            secondCircle.SetActive(true);
            second = true;
        }
    }

    public void thirdClue()
    {
        if (!third)
        {
            thirdT.GetComponent<Text>().color = Color.yellow;
            thirdCircle.SetActive(true);
            third = true;
        }

    }

    public void fourthClue()
    {
        if (!fourth)
        {
            fourthT.GetComponent<Text>().color = Color.yellow;
            fourthCircle.SetActive(true);
            fourth = true;
        }
    }

    public void fifthClue()
    {
        if (!fifth)
        {
            fifthT.GetComponent<Text>().color = Color.yellow;
            fifthCircle.SetActive(true);
            fifth = true;
        }
    }

    public void sixthClue()
    {
        if (!sixth)
        {
            sixthT.GetComponent<Text>().color = Color.yellow;
            sixthCircle.SetActive(true);
            sixth = true;
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
