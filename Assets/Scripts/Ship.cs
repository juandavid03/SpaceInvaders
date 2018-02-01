using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Ship : MonoBehaviour
{
    private Rigidbody2D nave;

    public GameObject bala;

    public int force;

    public bool canShoot = true;

    public int score = 0;

    private int vidas = 3;

    public Text vidasText;
    public Text scoreText;
    // Use this for initialization
    void Start ()
    {
        nave = this.gameObject.GetComponent<Rigidbody2D>();
        vidasText.text = vidas.ToString();
        scoreText.text = score.ToString();
    }
	
	// Update is called once per frame
	void Update ()
    {
        vidasText.text = vidas.ToString();
        scoreText.text = score.ToString();
        if (Input.GetKeyDown(KeyCode.A))
        {
            nave.AddForce(new Vector2(-force, 0));
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("MainMenu");
            if (PlayerPrefs.GetInt("HighScore") > score)
            {

                PlayerPrefs.SetInt("HighScore", score);
            }
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            nave.AddForce(new Vector2(force, 0));
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            nave.velocity = Vector2.zero;
        }

        if (Input.GetKeyUp(KeyCode.D))
        {
            nave.velocity = Vector2.zero;
        }

        if (Input.GetKeyDown(KeyCode.K))
        {
            if (canShoot)
            {
                Instantiate(bala, this.transform.position, Quaternion.identity);
                StartCoroutine(enableGunCR());
                canShoot = false;
            }
        }
        if (vidas < 0)
        {
            if (PlayerPrefs.GetInt("HighScore") > score)
            {
                PlayerPrefs.SetInt("HighScore", score);
            }
            SceneManager.LoadScene("GameOver");
        }
    }

    private IEnumerator enableGunCR()
    {
        yield return new WaitForSeconds(0.4f);
        canShoot = true;
    }

    public void RecibirDaño()
    {
        vidas--;
    }
}
