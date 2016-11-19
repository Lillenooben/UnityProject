using UnityEngine;
using System.Collections;

public class ProjectileScript : MonoBehaviour
{
    public ParticleSystem explosion;

    public int bulletTimer;

    // Use this for initialization
    void Start ()
    {

	}
	
	// Update is called once per frame
	void Update ()
    {
        bulletTimer--;
        if (bulletTimer <= 0)
        {
            Destroy(gameObject);
        }
        transform.Translate(Vector3.forward);
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "enemy")
        {
            
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
    
}
