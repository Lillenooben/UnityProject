using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour
{
    private float speed = 0.5f;

    //int x;
    //int z;

    public GameObject follow;

	// Use this for initialization
	void Start ()
    {
        //x = Random.Range(0, 8);
        //z = Random.Range(0, 0);
        //switch (x)
        //{
        //    //case 1:
        //    //    gameObject.transform.position = new Vector3(300, 0.5f, 285);
            //    break;
            //case 2:
            //    gameObject.transform.position = new Vector3(0, 0.5f, 285);
            //    break;
            //case 3:
            //    gameObject.transform.position = new Vector3(0, 0.5f, 285);
            //    break;
            //case 4:
            //    gameObject.transform.position = new Vector3(40, 0.5f, 20);
            //    break;
            //case 5:
            //    gameObject.transform.position = new Vector3(40, 0.5f, 20);
            //    break;
            //case 6:
            //    gameObject.transform.position = new Vector3(40, 0.5f, 20);
            //    break;
            //case 7:
            //    gameObject.transform.position = new Vector3(40, 0.5f, 20);
            //    break;
            //case 8:
            //    gameObject.transform.position = new Vector3(40, 0.5f, 20);
            //    break;


        //}

        follow = GameObject.FindGameObjectWithTag("Player");

        //transform.position = new Vector3(x, 0.5f, z);
    }
	
	// Update is called once per frame
	void Update ()
    {
        Vector3 followPos = follow.transform.position;
        gameObject.transform.LookAt(followPos);
        gameObject.transform.Translate(Vector3.forward * speed);

	}
    //void OnTriggerEnter(Collider other)
    //{
    //    if (other.gameObject.tag == "Player")
    //    {
    //        speed = 0;
    //        Debug.Log("Hej");
    //    }
        

    //}

}
