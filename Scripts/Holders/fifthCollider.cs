using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fifthCollider : MonoBehaviour
{
    public bool fifthColor;
    void Start()
    {
        fifthColor = false;
    }

    void Update()
    {

    }

    public void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("5"))
        {
            fifthColor = true;
        }
    }

    public void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("5"))
        {
            fifthColor = false;
        }
    }
}
