using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class howManyHints : MonoBehaviour
{
    public int amountOfHints;
    public Text hintsDisplay;
    // Start is called before the first frame update

    private void Awake()
    {
        PlayerPrefs.GetInt("amountOfHints", 0);

    }
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        hintsDisplay.text = "" + PlayerPrefs.GetInt("amountOfHints", 0);
        hintsDisplay.color = Color.white;

    }
    public void GiveOneHint()
    {
        int currentAmountOfHints = PlayerPrefs.GetInt("amountOfHints", 0);
        currentAmountOfHints += 1;
        PlayerPrefs.SetInt("amountOfHints", currentAmountOfHints);
        PlayerPrefs.Save();
    }
}
