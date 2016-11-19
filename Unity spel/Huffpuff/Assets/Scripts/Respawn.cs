using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Respawn : MonoBehaviour
{
    private int health = 5;

    public float respawnX;

    private Rigidbody rb;

    public Text text;
    public Text endText;

    public Canvas endscreen;
    


    public GameObject currentPlayer;
	// Use this for initialization
	void Start ()
    {
        rb = GetComponent<Rigidbody>();
        endText = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        //Writing out  the health of the players
        if (gameObject.tag == "Player1")
        {
            text.text = ("Player1: " + health + "HP");
        }
        else if (gameObject.tag == "Player2")
        {
            text.text = "Player2: " + health + "HP";
        }

        //Checking if the players have fallen off the platform and puts them back in, also checks health and destroys player if necessary
        if (transform.position.y <= -10)
        {
            health--;
            if (health > 0)
            {
                transform.position = new Vector3(respawnX, 2, 0);
                Debug.Log(currentPlayer.name + "-1 health, current health: " + health);
            }
            else if(health <= 0)
            {
                health = 0;
                endscreen.gameObject.SetActive(true);
                endText.text = currentPlayer.name + "Loses";
                Destroy(currentPlayer);
                Debug.Log(currentPlayer.name + " is out!");
            }
            rb.velocity = Vector3.zero;
        }
	}
}
