using UnityEngine;
using System.Collections;

public class Camera : MonoBehaviour
{
    public GameObject player;

    public float cameraHeight;

    private Vector3 playerPos;

	// Use this for initialization
	void Start ()
    {

	}
	
	// Update is called once per frame
	void Update ()
    {
        playerPos = new Vector3(player.transform.position.x, cameraHeight, player.transform.position.z);

        gameObject.transform.position = playerPos;
	}
}
