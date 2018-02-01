using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalaEnemiga : MonoBehaviour
{
    public int speed;
    public Ship ship;
	// Use this for initialization
	void Start ()
    {
        this.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, speed));
        ship = GameObject.Find("Ship").GetComponent<Ship>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 9)
        {
            ship.RecibirDaño();
            Destroy(this.gameObject);
        }
        if (collision.gameObject.layer == 12)
        {
            Destroy(this.gameObject);
        }
    }

}
