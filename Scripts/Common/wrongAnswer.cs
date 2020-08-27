using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wrongAnswer : MonoBehaviour
{
    public void wrongAnswerMethod()
    {
        StartCoroutine(userPickWrong());
    }
    public IEnumerator userPickWrong()
    {
        this.transform.GetChild(0).gameObject.SetActive(true);
        yield return new WaitForSeconds(2.5f);
        this.transform.GetChild(0).gameObject.SetActive(false);
    }


}
