using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class quizManager : MonoBehaviour
{
    public AudioClip correctAnswerSound;
    public AudioClip wrongAnswerSound;
    public AudioSource audioSource;
    public Text hintsDisplay;
    public int amountOfHintsLeft;
    public GameObject hintEnough;
    public GameObject hintLack;
    public GameObject skipLack;
    public GameObject skipEnough;
    public UnityMonetization ads;



    private void Start()
    {
        AudioSource audio = GetComponent<AudioSource>();
        PlayerPrefs.GetInt("amountOfHints", 0);
        hintsDisplay.color = Color.white;
    }

    private void Update()
    {
        hintsDisplay.text = "" + PlayerPrefs.GetInt("amountOfHints", 0);
    }
    public void WrongAnswer()
    {
        PlayWrongBuzzer();
    }

    public void CorrectAnswer()
    {
        PlayCorrectDing();
    }

    public void PlayWrongBuzzer()
    {
        GetComponent<AudioSource>().PlayOneShot(wrongAnswerSound);
    }

    public void PlayCorrectDing()
    {
        GetComponent<AudioSource>().PlayOneShot(correctAnswerSound);
    }

    public void hintUsed()
    {
        if (PlayerPrefs.GetInt("amountOfHints", 0) > 0)
        {
            int currentAmountOfHints = PlayerPrefs.GetInt("amountOfHints", 0);
            currentAmountOfHints -= 1;
            PlayerPrefs.SetInt("amountOfHints", currentAmountOfHints);
            PlayerPrefs.Save();
            hintEnough.SetActive(true);
        }
        else
        {
            hintLack.SetActive(true);
        }
    }

    public void GiveOneHint()
    {
        int currentAmountOfHints = PlayerPrefs.GetInt("amountOfHints", 0);
        currentAmountOfHints += 1;
        PlayerPrefs.SetInt("amountOfHints", currentAmountOfHints);
        PlayerPrefs.Save();
    }

    public void SkipLevelBox()
    {
        if (PlayerPrefs.GetInt("amountOfHints", 0) > 1) 
            {
                skipEnough.SetActive(true);
            }   

        else
        {
            skipLack.SetActive(true);
        }
    }

    public void skipLevel(int number)
    {
        int currentAmountOfHints = PlayerPrefs.GetInt("amountOfHints", 0);
        currentAmountOfHints -= 2;

        ads.DeleteListener();


        PlayerPrefs.SetInt("amountOfHints", currentAmountOfHints);
        PlayerPrefs.SetInt("Level" + number.ToString(), 3);  // 3 => true , 0 => false


        PlayerPrefs.Save();

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }



}
