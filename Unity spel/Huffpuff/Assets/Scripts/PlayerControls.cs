using UnityEngine;
using System.Collections;

public class PlayerControls : MonoBehaviour
{

    public float speed;

    Rigidbody rb;

	void Start ()
    {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (gameObject.tag == "Player1") //Checks player and calls the correct class
        {
            Playermove1();
        }


        if (gameObject.tag == "Player2") //Checks player and calls the correct class
        {
            Playermove2();
        }

    }
    void Playermove1()  //Checking and making movements of Player1
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(new Vector3(0, 0, speed));
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(new Vector3(0, 0, speed * -1));
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(new Vector3(speed * -1, 0, 0));
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(new Vector3(speed, 0, 0));
        }
    }


    void Playermove2()  //Checking and making movements of Player2
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.AddForce(new Vector3(0, 0, speed));
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            rb.AddForce(new Vector3(0, 0, speed * -1));
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(new Vector3(speed * -1, 0, 0));
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(new Vector3(speed, 0, 0));
        }
    }
    
}
