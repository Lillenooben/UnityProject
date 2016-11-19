using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Transform_Movement : MonoBehaviour
{
    public int health;
    public float speed;

    public Text healthText;
    

    int spawnTimer = 100;

    public GameObject enemy;

    public GameObject cannon;
    public GameObject prefab;
    public float projectileSpeed;

    public Canvas endscreen;

    // Use this for initialization
    void Start ()
    {

    }
	
	// Update is called once per frame
	void Update ()
    {
        healthText.text = ("Health: " + health);

        Vector3 mousePos = Input.mousePosition;
        gameObject.transform.LookAt(new Vector3 (mousePos.x - Screen.width/2, 0, mousePos.y - Screen.height/2));
        //Debug.Log(mousePos);
        TransformMovement();
        Shoot();


        //if (health > 0)
        //{
        //    spawnTimer--;

        //    if (spawnTimer <= 0)
        //    {
        //        Instantiate(enemy, new Vector3(0, 0.5f, 0), Quaternion.identity);
        //        spawnTimer = 100;
        //    }
        //}
        if (health <= 0)
        {
            endscreen.gameObject.SetActive(true);
        }


    }
    void TransformMovement()
    {
        if (Input.GetKey(KeyCode.W))
            gameObject.transform.Translate(Vector3.forward * speed);

        if (Input.GetKey(KeyCode.S))
            gameObject.transform.Translate(Vector3.back * speed);

        if (Input.GetKey(KeyCode.A))
            gameObject.transform.Translate(Vector3.left * speed);

        if (Input.GetKey(KeyCode.D))
            gameObject.transform.Translate(Vector3.right * speed);
    }


    void Shoot()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Rigidbody instantiatedProjectile = Instantiate(prefab, cannon.transform.position, cannon.transform.rotation) as Rigidbody;

        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "enemy")
        {
            health--;
            Destroy(other.gameObject);
        }
    }
}
