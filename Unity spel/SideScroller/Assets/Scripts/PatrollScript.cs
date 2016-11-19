using UnityEngine;
using System.Collections;

public class PatrollScript : MonoBehaviour
{

    public int direction = 1;

    public float speed;

	// Use this for initialization
	void Start ()
    {

	}
	
	// Update is called once per frame
	void Update ()
    {
        Movement();
	}

    void OnTriggerEnter(Collider other)

    {
        if (other.gameObject.tag == "Turn")
        {
            direction *= -1;
        }
    }

    void Movement()
    {
        gameObject.transform.position += new Vector3(direction * speed, 0, 0);
    }
}
