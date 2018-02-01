using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject[] enemies;

    public float tiempo;

    public int index;

    // Use this for initialization
    void Start ()
    {
        tiempo = UnityEngine.Random.Range(1, 10);
    }
	
	// Update is called once per frame
	void Update ()
    {
        tiempo -= Time.deltaTime;
        if (tiempo <= 0)
        {
            tiempo = UnityEngine.Random.Range(3, 10);
            InstantiateEnemy();

        }
	}

    void InstantiateEnemy()
    {
        index = UnityEngine.Random.Range(0, enemies.Length);
        Instantiate(enemies[index], this.transform.position, Quaternion.identity);
        StartCoroutine(enableSpawnCR());
    }

    private IEnumerator enableSpawnCR()
    {
        yield return new WaitForSeconds(tiempo);

    }
}
