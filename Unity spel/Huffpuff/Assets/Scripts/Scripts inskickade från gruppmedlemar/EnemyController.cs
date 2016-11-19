using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour {

    Rigidbody rb;
    float speed = 15;

    float x;
    float z;

    public GameObject player;

    void Start () {

        rb = GetComponent<Rigidbody>();

        x = Random.Range(-15, 15);
        z = Random.Range(-15, 15);

        transform.position = new Vector3(x, 0.5f, z);

	}

    void FixedUpdate()
    {

        if (player)
        {
        transform.LookAt(player.transform.position);
        }

        

        rb.AddRelativeForce(Vector3.forward * speed);

    }
    void OnCollisionEnter(Collision collision)
    {
        /*if (collision.gameObject.name == "Player")
        {
            Destroy(collision.gameObject);

        }*/
    }
}
