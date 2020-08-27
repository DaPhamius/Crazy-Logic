using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fourthCollider : MonoBehaviour
{
    public bool fourthColor;
    void Start()
    {
        fourthColor = false;
    }

    void Update()
    {

    }

    public void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("4"))
        {
            fourthColor = true;
        }
    }

    public void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("4"))
        {
            fourthColor = false;
        }
    }
}
