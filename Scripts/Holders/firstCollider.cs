using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firstCollider : MonoBehaviour
{
    public bool firstColor;
    void Start()
    {
        firstColor = false;
    }

    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("1"))
        {
            firstColor = true;
        }
    }

    public void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("1"))
        {
            firstColor = false;
        }
    }
}
