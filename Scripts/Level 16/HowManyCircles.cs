using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HowManyCircles : MonoBehaviour
{
    public InputField mainInputField;
    public string myText;
    public quizManager qM;
    public GameObject correct;
    public GameObject success;
    public GameObject wrong;
    

    public void CheckAnswer()
    {
        myText = mainInputField.text;
        if (myText == "5")
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
        qM.CorrectAnswer();
        correct.transform.gameObject.SetActive(true);
        yield return new WaitForSeconds(2.5f);
        success.SetActive(true);
        yield return new WaitForSeconds(1.5f);
    }

    public IEnumerator userPickWrong()
    {
        qM.WrongAnswer();
        wrong.transform.gameObject.SetActive(true);
        yield return new WaitForSeconds(2.5f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }
}
