using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NinthNonoGram : MonoBehaviour
{
    public bool changed;
    public Button button;

    void Start()
    {
        changed = false;
    }


    public void Click()
    {
        if (!changed)
        {
            GetComponent<Image>().color = Color.yellow;
            changed = true;
        }
        else if (changed)
        {
            GetComponent<Image>().color = Color.white;
            changed = false;
        }
    }
}
