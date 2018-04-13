using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour {
    private GameObject player;
    private Vector3 cameraOffset;

	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
        cameraOffset = new Vector3(-1, 38, -3);
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = player.transform.position + cameraOffset;
	}
}
