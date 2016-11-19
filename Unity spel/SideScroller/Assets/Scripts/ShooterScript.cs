using UnityEngine;
using System.Collections;

public class ShooterScript : MonoBehaviour
{

    int timer = 100;

    public Rigidbody projectile;

	// Use this for initialization
	void Start ()
    {
	    
	}
	
	// Update is called once per frame
	void Update ()
    {
        Shoot();
	}

    void Shoot()
    {
        timer--;
        if (timer <= 0)
        {
            Rigidbody instantiatedProjectile = Instantiate(projectile, gameObject.transform.position, gameObject.transform.rotation) as Rigidbody;
            timer = 160;
        }
    }
}
