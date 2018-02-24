using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Controls : MonoBehaviour
{
    public float playerSpeed = 7;
    public float RotateSpeed = 200;
    private Rigidbody rb;
    private Vector3 playerInput;
    private Vector3 playerVelocity;
    private Camera mainCamera;
    // Use this for initialization
    void Start()
    {
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
        float rayLength;
       // if (ground.Raycast(ray, out rayLength))
        //{
         //   Vector3 pointToLook = ray.GetPoint(rayLength);
          //  transform.LookAt(new Vector3(pointToLook.x, pointToLook.y, pointToLook.z));
       // }//gets character to follow mouse
        if (Input.GetMouseButton(0))//tracks left click mouse button
        {
            transform.Rotate(-Vector3.up * RotateSpeed * Time.deltaTime);
        }
        else if(Input.GetMouseButton(1))
        {
            transform.Rotate(Vector3.up * RotateSpeed * Time.deltaTime);
        }
    }
    private void FixedUpdate()
    {
        rb.velocity = playerVelocity;
    }
}
