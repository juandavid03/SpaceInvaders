using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuperSpawner : MonoBehaviour
{
    private static SuperSpawner instance = null;

    // Game Instance Singleton
    public static SuperSpawner Instance
    {
        get
        {
            return instance;
        }
    }

    private void Awake()
    {
        // if the singleton hasn't been initialized yet
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
        }

        instance = this;
    }

    public GameObject enemy;

    public Ship ship;
    public float tiempo = 5;

    public bool canSpawn = true;

    // Use this for initialization
    void Start ()
    {
        ship = GameObject.Find("Ship").GetComponent<Ship>();
    }
	
	// Update is called once per frame
	void Update ()
    {

        if (ship.score > 500 && canSpawn)
        {
            tiempo -= Time.deltaTime;
            if (tiempo <= 0)
            {
                canSpawn = false;
                InstantiateEnemy();
                tiempo = 10;
            }
        }
	}

    void InstantiateEnemy()
    {
        Instantiate(enemy, this.transform.position, Quaternion.identity);
        
    }

}
