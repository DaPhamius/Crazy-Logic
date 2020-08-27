using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Nonogram : MonoBehaviour
{
    public FirstNonoGram first;
    public SecondNonoGram second;
    public ThirdNonoGram third;
    public FourthNonoGram fourth;
    public FifthNonoGram fifth;
    public SixthNonoGram sixth;
    public SeventhNonoGram seventh;
    public EighthNonoGram eight;
    public NinthNonoGram ninth;
    public quizManager qm;
    public GameObject wrong;
    public GameObject correct;
    public GameObject success;

    void Start()
    {
        
    }

    // Update is called once per frame
    public void checkResults()
    {
        if (first.changed && second.changed && third.changed && fourth.changed && !fifth.changed && sixth.changed && seventh.changed && eight.changed && ninth.changed)
        {
            StartCoroutine(userPickCorrect());
        }
        else
        {
            StartCoroutine(userPickWrong());
        }
    }

    public IEnumerator userPickCorrect()
    {
        qm.CorrectAnswer();
        correct.transform.gameObject.SetActive(true);
        yield return new WaitForSeconds(2.5f);
        success.SetActive(true);
    }

    public IEnumerator userPickWrong()
    {
        qm.WrongAnswer();
        wrong.transform.gameObject.SetActive(true);
        yield return new WaitForSeconds(2.5f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }

}
