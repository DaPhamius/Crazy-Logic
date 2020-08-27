using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class thirdCollider : MonoBehaviour
{
    public bool thirdColor;
    void Start()
    {
        thirdColor = false;
    }

    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("3"))
        {
            thirdColor = true;
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("3"))
        {
            thirdColor = false;
        }
    }
}
