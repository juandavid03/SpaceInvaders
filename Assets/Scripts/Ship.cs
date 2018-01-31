using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour
{
    private Rigidbody2D nave;

    public int force;
	// Use this for initialization
	void Start ()
    {
        nave = this.gameObject.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            nave.AddForce(new Vector2(-force, 0));
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            nave.AddForce(new Vector2(force, 0));
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            nave.AddForce(new Vector2(force, 0));
        }

        if (Input.GetKeyUp(KeyCode.D))
        {
            nave.AddForce(new Vector2(-force, 0));
        }
    }
}
