using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BackGroundChange : MonoBehaviour
{
    public bool blue = false;
    public bool red = false;
    public bool grey = false;
    public bool green = false;
    public bool yellow = false;
    public float inputTimer;
    public bool win = false;
    public bool fail = false;
    public quizManager qm;
    public GameObject correct;
    public GameObject success;
    public GameObject wrong;
    public bool gameCompleted = false;

    void Start()
    {
        inputTimer = 0;
        fail = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (yellow)
        {
            inputTimer += Time.deltaTime;

            if(inputTimer < 5 && Input.GetMouseButtonDown(0))
            {
                StartCoroutine(userPickWrong());
                fail = true;
            }

            else if (inputTimer > 5 && !fail)
            {
                win = true;
            }
            
        }

        if (win && !gameCompleted) 
        {
            StartCoroutine(userPickCorrect());
        }
    }

    public void click()
    {
        if (!blue)
        {
            GetComponent<Image>().color = Color.blue;
            blue = true;
        }

        else if (blue && !red)
        {
            GetComponent<Image>().color = Color.red;
            red = true;
        }

        else if (blue && red && !grey)
        {
            GetComponent<Image>().color = Color.grey;
            grey = true;
        }

        else if (blue && red && grey && !green)
        {
            GetComponent<Image>().color = Color.green;
            green = true;
        }

        else if (blue && red && grey && green && !yellow)
        {
            GetComponent<Image>().color = Color.yellow;
            yellow = true;
        }
    }

    public IEnumerator userPickCorrect()
    {
        gameCompleted = true;
        qm.CorrectAnswer();
        correct.SetActive(true);
        yield return new WaitForSeconds(2.5f);
        success.SetActive(true);
        yield return new WaitForSeconds(1.5f);
    }
    public IEnumerator userPickWrong()
    {
        qm.WrongAnswer();
        wrong.SetActive(true);
        yield return new WaitForSeconds(2.5f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }

}
