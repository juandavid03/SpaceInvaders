using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invisibility : MonoBehaviour
{
    private bool isVisible = true;
	// Use this for initialization
	void Start ()
    {
        StartCoroutine(ChangeVisibilityCR());
	}

    private IEnumerator ChangeVisibilityCR()
    {
        if (isVisible)
        {
            yield return new WaitForSeconds(2);
            isVisible = !isVisible;
        }
        if (!isVisible)
        {
            yield return new WaitForSeconds(1);
            isVisible = !isVisible;
        }

        StartCoroutine(ChangeVisibilityCR());
    }

    // Update is called once per frame
    void Update ()
    {
        if (isVisible)
        {
            this.gameObject.GetComponent<SpriteRenderer>().enabled = true;
        }
        else if (!isVisible)
        {
            this.gameObject.GetComponent<SpriteRenderer>().enabled = false; ;
        }
    }
}
