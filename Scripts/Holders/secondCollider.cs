using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class secondCollider : MonoBehaviour
{
    public bool secondColor;
    void Start()
    {
        secondColor = false;
    }

    void Update()
    {

    }

    public void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("2"))
        {
            secondColor = true;
        }
    }

    public void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("2"))
        {
            secondColor = false;
        }
    }
}
