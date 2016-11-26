using UnityEngine;
using System.Collections;

public class FlyController : MonoBehaviour
{
    public float speed;
    int timer = 0;
    int turnTimer = 0;

    public Rigidbody rb;

    // Use this for initialization
    void Start()
    {
        rb.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //rb.AddRelativeForce(new Vector3(0, 10, 15));

        TransformMovement();
    }

    void TransformMovement()
    {
        //rb.AddRelativeForce(new Vector3(-10, -5, 0));

        Debug.Log(transform.rotation.x);

        if (Input.GetKey(KeyCode.W))
        {
            
            timer = 0;
            gameObject.transform.Rotate(new Vector3(-1, transform.rotation.y, transform.rotation.z));
        }
        else if (Input.GetKey(KeyCode.LeftShift))
        {
            rb.AddRelativeForce(new Vector3(0, 10, 15));
        }

        else if (Input.GetKey(KeyCode.LeftControl))
        {
            rb.AddRelativeForce(new Vector3(0, 0, -5));
        }

        else if (Input.GetKey(KeyCode.S))
        {
            //gameObject.transform.

            rb.AddRelativeForce(new Vector3(0, 0, -5));
            //if (transform.rotation.x < 0.20f)
            //{
            gameObject.transform.Rotate(new Vector3(1, transform.rotation.y, transform.rotation.z));
            //}

        }


        if (Input.GetKey(KeyCode.E))
        {
            gameObject.transform.Rotate(new Vector3(0, 1, -1));
            rb.AddRelativeForce(new Vector3(3, 0, 0));
        }

        if (Input.GetKey(KeyCode.Q))
        {
            gameObject.transform.Rotate(new Vector3(0, -1, 1));
            rb.AddRelativeForce(new Vector3(-3, 0, 0));

        }
    }
}
