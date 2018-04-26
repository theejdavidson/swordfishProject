using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
public class Controls : MonoBehaviour
{
    public float playerSpeed = 7;
    public static float RotateSpeed;
    //public float thrust = 4;
    public Rigidbody rb;
    private Vector3 playerInput;
    public Vector3 playerVelocity;
    private Camera mainCamera;
    // Use this for initialization
    void Start()
    {
        RotateSpeed = 200;
        rb = GetComponent<Rigidbody>(); //maps rigidbody to player
        mainCamera = FindObjectOfType<Camera>(); //maps camera controls to main camera in game
    }

    // Update is called once per frame
    void Update()
    {
        
        playerInput = new Vector3(Input.GetAxisRaw("Horizontal"), 0f, Input.GetAxisRaw("Vertical")); //keeps player moving in 2 dimension
        playerVelocity = playerInput * playerSpeed; //players velocity when moved
        Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition); //makes character face mouse
        Plane ground = new Plane(Vector3.up, Vector3.zero);
        //float rayLength;
        // if (ground.Raycast(ray, out rayLength))
        //{
        //   Vector3 pointToLook = ray.GetPoint(rayLength);
        //  transform.LookAt(new Vector3(pointToLook.x, pointToLook.y, pointToLook.z));
        // }//gets character to follow mouse

        if (Input.GetMouseButton(0))//tracks left click mouse button
        {
            transform.Rotate(-Vector3.up * (RotateSpeed * Time.deltaTime));
        }
        if (RotateSpeed < 2000)
            RotateSpeed += 2;
        if (Input.GetMouseButton(0) == false)
            RotateSpeed = 200;
        else if (Input.GetMouseButton(1))
        {
            transform.Rotate(Vector3.up * RotateSpeed * Time.deltaTime);
        }
    }
    private void FixedUpdate()
    {
        rb.velocity = playerVelocity;
        //rb.AddForce(thrust, 0, thrust, ForceMode.Acceleration);
    }

    public float getRSpeed()
    {
        return RotateSpeed;
    }

    public void setRSpeed(float speed)
    {
        RotateSpeed -= speed;
    }
}
