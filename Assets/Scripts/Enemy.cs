﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public bool isGoingRight;

    public Rigidbody2D enemigo;

    public int direccion;

    public int fuerza;
    public int puntaje;

    public Ship ship;

	// Use this for initialization
	void Start ()
    {
        enemigo = this.gameObject.GetComponent<Rigidbody2D>();
        ship = GameObject.Find("Ship").GetComponent<Ship>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (PlayerPrefs.GetInt("HighScore") > puntaje)
        {
            PlayerPrefs.SetInt("HighScore", puntaje);
        }
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

        if (collision.gameObject.CompareTag("Bottom"))
        {
           ship.RecibirDaño();
        }
    }
}
