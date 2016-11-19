using UnityEngine;
using System.Collections;

public class ProjectileScript : MonoBehaviour
{
    public float speed;
    int projectileTimer = 300;

	// Use this for initialization
	void Start ()
    {

	}
	
	// Update is called once per frame
	void Update ()
    {
        projectileTimer--;
        gameObject.transform.Translate(Vector3.forward * speed);
        if (projectileTimer <= 0)
        {
            Destroy(gameObject);
        }
        
	}

    
}
