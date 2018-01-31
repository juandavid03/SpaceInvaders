using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{

	// Use this for initialization
	void Start ()
    {
        this.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 200));
	}
	
}
