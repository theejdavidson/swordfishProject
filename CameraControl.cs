using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    private GameObject player;
    private Vector3 cameraOffset;

    // Use this for initialization
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        cameraOffset = new Vector3(-1, 30, -3);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + cameraOffset;
    }
}


/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour {
    private GameObject player;
    private Vector3 cameraOffset;
    private float timer = 0f;
    private Vector3 currentPosition;
    private Vector3 n = new Vector3(0, 0, 0);
    // Use this for initialization
    void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
        cameraOffset = new Vector3(-1, 38, -3);
        transform.position = player.transform.position + cameraOffset;
	}
	
	// Update is called once per frame
	void Update () {
        if((Vector3.Distance(transform.position, player.transform.position)) != (Vector3.Distance(cameraOffset, n)))
        {
            transform.Translate(transform.forward);
        }
        else
        {
            transform.position = player.transform.position + cameraOffset;
        }

    }


*/
