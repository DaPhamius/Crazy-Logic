using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShakeDetection : MonoBehaviour
{

    public quizManager qM;
    public GameObject correct;
    public GameObject success;
    public bool gameCompleted = false;

    Vector3 accelerationDir;

    void Update()
    {
        accelerationDir = Input.acceleration;

        if (accelerationDir.sqrMagnitude >= 5f && !gameCompleted)
        {
            StartCoroutine(userPickCorrect());
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
