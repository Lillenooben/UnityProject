using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    //UI
    public Text healthText;
    public Text scoreText;
    public Text deathText;
    public Canvas victory;
    public Text victoryStats;

    //UI variables
    public int health;
    int score;
    int deaths = 0;

    int savedHealth;
    
    public float speed;

    Vector3 spawnPos;

    Rigidbody rb;

    bool canJump = false;

	void Start ()
    {
        rb = GetComponent<Rigidbody>();
        savedHealth = health;
        spawnPos = gameObject.transform.position;
	}
	
	void Update ()
    {
        victoryStats.text = ("Deaths: " + deaths + ". Score: " + score);
        healthText.text = ("Health: " + health);
        scoreText.text = ("Score: " + score);
        deathText.text = ("Death(s): " + deaths);
        TransformMovement();
        Respawn();
        
    }

    void Respawn()
    {
        if (health <= 0)
        {
            deaths++;
            gameObject.transform.position = spawnPos;
            health = savedHealth;
        }
        if (gameObject.transform.position.y <= -10)
        {
            deaths++;
            gameObject.transform.position = spawnPos;
            health = savedHealth;
        }

    }

    void TransformMovement()
    {
        if (Input.GetKey(KeyCode.D))
            gameObject.transform.Translate(Vector3.forward * speed);
        if (Input.GetKey(KeyCode.A))
            gameObject.transform.Translate(Vector3.back * speed);
        if (Input.GetKeyDown(KeyCode.W) && canJump == true)
            rb.AddForce(new Vector3(0, 2100, 0));

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            canJump = true;
        }

        if (collision.gameObject.tag == "projectile")
        {
            Destroy(collision.gameObject);
            health--;
        }
        
        if (collision.gameObject.tag == "Enemy")
        {
            health--;
        }
    }
    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            canJump = false;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Coin")
        {
            Destroy(other.gameObject);
            score++;
        }
        if (other.gameObject.tag == "Goal")
        {
            victory.gameObject.SetActive(true);
        }
    }

}
