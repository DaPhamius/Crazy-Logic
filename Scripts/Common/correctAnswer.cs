using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class correctAnswer : MonoBehaviour
{
    public GameObject success;
    public void correctAnswerMethod()
    {
        StartCoroutine(userPickCorrect());
    }
    public IEnumerator userPickCorrect()
    {
        this.transform.GetChild(0).gameObject.SetActive(true);
        yield return new WaitForSeconds(2.5f);
        success.SetActive(true);
        yield return new WaitForSeconds(1.5f);
    }





}
