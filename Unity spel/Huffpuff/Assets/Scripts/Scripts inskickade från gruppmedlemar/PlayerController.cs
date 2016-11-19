using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    Rigidbody rb;
    float speed = 15;
    int spawnTimer = 100;

    public GameObject enemy;

	void Start () {

        rb = GetComponent<Rigidbody>();

      

	}


    void FixedUpdate()
    {
        Vector3 mousePos = Input.mousePosition;

        transform.LookAt(new Vector3(mousePos.x - Screen.width / 2, 0 , mousePos.y - Screen.height / 2));

        //rb.AddRelativeForce(Vector3.forward * speed);

        spawnTimer--;

        if (spawnTimer <= 0)
        {
            Instantiate(enemy, new Vector3(0, 0.5f, 0), Quaternion.identity);
            spawnTimer = 100;
        }

    }
}