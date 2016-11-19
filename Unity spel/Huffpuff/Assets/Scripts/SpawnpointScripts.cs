using UnityEngine;
using System.Collections;

public class SpawnpointScripts : MonoBehaviour
{

    int spawnTimer = 500;

    public GameObject enemy;

    // Use this for initialization
    void Start ()
    { 
        
	}
	
	// Update is called once per frame
	void Update ()
    { 
            spawnTimer--;

        if (spawnTimer <= 0)
        {
            Instantiate(enemy, new Vector3(gameObject.transform.position.x, 0.5f, gameObject.transform.position.z), Quaternion.identity);
            spawnTimer = 500;
        }
        

    }
}
