using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelector : MonoBehaviour{

    //public GameObject loading;
    public UnityMonetization ads;
    public GameObject[] levelLocks;

    void Start()
    {

        PlayerPrefs.SetInt("Level1", 3);
        
        for (int a = 1; a < levelLocks.Length; a++)
        {

            if (PlayerPrefs.GetInt("Level" + a.ToString()) == 3)  // 3 => true , 0 => false
                levelLocks[a].SetActive(false);
            else
                levelLocks[a].SetActive(true);

        }
    }

    /*public void Update()
    {
        int number = 3;
        if (Input.GetKeyDown("space"))
        {
            Debug.Log("Levels" + number.ToString());
        }
    }*/


    public void SelectLevel(int number)
    {
        if (PlayerPrefs.GetInt("Level" + number.ToString()) == 3)
        {  // 3 => true , 0 => false
            ads.DeleteListener();
            //loading.SetActive(true);
            SceneManager.LoadScene("Level" + number.ToString());

        }
    }

    public void SelectLevel (string levelName)

    {
        ads.DeleteListener();

        SceneManager.LoadScene(levelName);
    }

    public void UnlockLevel(int number)
    {
        PlayerPrefs.SetInt("Level" + number.ToString(), 3);  // 3 => true , 0 => false
    }


}
