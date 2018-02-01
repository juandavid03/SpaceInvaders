using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
    public Ship ship;
	// Use this for initialization
	void Start ()
    {
        ship = GameObject.Find("Ship").GetComponent<Ship>();
        this.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 200));
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 8)
        {
            ship.score += collision.gameObject.GetComponent<Enemy>().puntaje;
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
        }
    }

}
