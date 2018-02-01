using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public bool isGoingRight;

    public Rigidbody2D enemigo;

    public int direccion;

    public int fuerza;
    public int puntaje; 

	// Use this for initialization
	void Start ()
    {
        enemigo = this.gameObject.GetComponent<Rigidbody2D>();
        
    }
	
	// Update is called once per frame
	void Update ()
    {
        enemigo.AddForce(new Vector2(direccion * fuerza, 0));
        if (isGoingRight)
        {
            direccion = 1;
        }
        else if (!isGoingRight)
        {
            direccion = -1;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        enemigo.transform.position += new Vector3(0, -1, 0);
        if (collision.gameObject.CompareTag("Side"))
        {
            isGoingRight = !isGoingRight;
        }
    }
}
