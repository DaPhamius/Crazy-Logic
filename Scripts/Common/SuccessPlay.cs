using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuccessPlay : MonoBehaviour
{
    public AudioClip celebration;
    public AudioSource aS;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(delayedSound());
    }

    IEnumerator delayedSound()
    {
        yield return new WaitForSeconds(1);
        aS.PlayOneShot(celebration);
    }
}
