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
        rb.AddRelativeForce(new Vector3(0, 10, 15));

        TransformMovement();
    }

    void TransformMovement()
    {

        Debug.Log(transform.rotation.x);

        if (Input.GetKey(KeyCode.W))
        {
            rb.AddRelativeForce(new Vector3(10, 0, 0));
            timer = 0;
            gameObject.transform.Rotate(new Vector3(-1, transform.rotation.y, transform.rotation.z));
        }

        else if (Input.GetKey(KeyCode.S))
        {
            //gameObject.transform.


            //if (transform.rotation.x < 0.20f)
            //{
            gameObject.transform.Rotate(new Vector3(1, transform.rotation.y, transform.rotation.z));
            //}

        }


        if (Input.GetKey(KeyCode.E))
            gameObject.transform.Rotate(new Vector3(0, 1, 1));

        if (Input.GetKey(KeyCode.Q))
            gameObject.transform.Rotate(new Vector3(0, -1, -1));



        //if (Input.GetKey(KeyCode.S))
        //    gameObject.transform.Translate(Vector3.back * speed);

        //Unused jumping script
        //if (Input.GetKeyDown(KeyCode.W) && canJump == true)
        //    rb.AddForce(new Vector3(0, 2100, 0));

    }
}
