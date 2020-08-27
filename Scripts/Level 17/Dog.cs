using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : MonoBehaviour
{

    public GameObject madZoro;
    public GameObject happyZoro;
    public quizManager qm;
    public GameObject correct;
    public GameObject success;
    public GameObject stick;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D col)
    {
        StartCoroutine(userPickCorrect());
    }

    public IEnumerator userPickCorrect()
    {
        qm.CorrectAnswer();
        madZoro.SetActive(false);
        happyZoro.SetActive(true);
        stick.SetActive(false);
        yield return new WaitForSeconds(1);
        correct.transform.gameObject.SetActive(true);
        yield return new WaitForSeconds(2.5f);
        success.SetActive(true);
    }
}
