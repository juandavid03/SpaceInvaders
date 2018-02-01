using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienGun : MonoBehaviour
{

    public GameObject bullet;
	// Use this for initialization
	void Start ()
    {
        StartCoroutine(ShootCR());
	}

    private IEnumerator ShootCR()
    {
        yield return new WaitForSeconds(3);
        Disparar();
        StartCoroutine(ShootCR());
    }


    public void Disparar()
    {
        Instantiate(bullet, this.transform.position, Quaternion.identity);
    }
}
