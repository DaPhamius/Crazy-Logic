using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isTextTouching : MonoBehaviour
{
    public bool isTouching;
    public void Start()
    {
        isTouching = false;
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Text"))
        {
            isTouching = true;
        }
    }
}
