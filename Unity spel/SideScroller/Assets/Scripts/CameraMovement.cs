using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour
{
    public GameObject player;

    public int cameraHeight;
    public float cameraZ;

    private Vector3 playerPos;

    // Use this for initialization
    void Start ()
    {

	}
	
	// Update is called once per frame
	void Update ()
    {
        playerPos = new Vector3(player.transform.position.x, player.transform.position.y + cameraHeight, cameraZ);

        gameObject.transform.position = playerPos;
    }
}
