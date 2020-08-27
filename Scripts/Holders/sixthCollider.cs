using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sixthCollider : MonoBehaviour
{
    public bool sixthColor;
    void Start()
    {
        sixthColor = false;
    }

    void Update()
    {

    }

    public void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("6"))
        {
            sixthColor = true;
        }
    }

    public void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("6"))
        {
            sixthColor = false;
        }
    }
}
