using UnityEngine;
using System.Collections;

public class FlyController : MonoBehaviour
{
    public float speed;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        TransformMovement();
    }

    void TransformMovement()
    {

        if (Input.GetKey(KeyCode.W))
            gameObject.transform.Translate(Vector3.forward * speed);
        else
        {
            
            gameObject.transform.Translate(Vector3.forward * 0.15f);
        }
            

        if (Input.GetKey(KeyCode.E))
            gameObject.transform.Rotate(new Vector3(0, 1, 0));

        if (Input.GetKey(KeyCode.Q))
            gameObject.transform.Rotate(new Vector3(0, -1, 0));


        //if (Input.GetKey(KeyCode.S))
        //    gameObject.transform.Translate(Vector3.back * speed);

        //Unused jumping script
        //if (Input.GetKeyDown(KeyCode.W) && canJump == true)
        //    rb.AddForce(new Vector3(0, 2100, 0));

    }
}
