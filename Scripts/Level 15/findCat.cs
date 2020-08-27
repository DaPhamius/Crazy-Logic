using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class findCat : MonoBehaviour
{

    public bool gameCompleted = false;
    public quizManager qM;
    public GameObject correct;
    public GameObject success;

    public void pick()
    {
        StartCoroutine(userPickCorrect());
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
