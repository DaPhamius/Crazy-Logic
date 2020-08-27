using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrackedCup : MonoBehaviour
{
    public bool firstCrack = false;
    public bool secondCrack = false;
    public bool thirdCrack = false;
    public bool brokenCup = false;
    public GameObject uncracked;
    public GameObject firstCracks;
    public GameObject secondCracks;
    public GameObject thirdCracks;
    public GameObject brokenCups;
    void Start()
    {
        
    }

    public void crack()
    {
        if (!firstCrack)
        {
            firstCrack = true;
            uncracked.SetActive(false);
            firstCracks.SetActive(true);
        }

        else if (firstCrack && !secondCrack)
        {
            secondCrack = true;
            firstCracks.SetActive(false);
            secondCracks.SetActive(true);
        }

        else if (firstCrack && secondCrack && !thirdCrack)
        {
            thirdCrack = true;
            secondCracks.SetActive(false);
            thirdCracks.SetActive(true);
        }

        else if (firstCrack && secondCrack && thirdCrack && !brokenCup)
        {
            brokenCup = true;
            thirdCracks.SetActive(false);
            brokenCups.SetActive(true);
        }
    }
}
