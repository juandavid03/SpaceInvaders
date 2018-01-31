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

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 8)
        {
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
        }
    }

}
