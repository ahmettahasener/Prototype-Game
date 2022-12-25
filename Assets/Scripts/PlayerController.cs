using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horsePower;
    public float turnSpeed;
    private float horizontalInput;
    private float verticalInput;
    public Rigidbody vehicleRb;
    [SerializeField] private GameObject centerOfMass;
    [SerializeField] private List<WheelCollider> allWheels;
    [SerializeField] private int wheelsOnGround;

    private void Start()
    {
        vehicleRb = GetComponent<Rigidbody>();
        vehicleRb.centerOfMass = centerOfMass.transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (IsOnGround())
        {
            //This is where we get player input.
            horizontalInput = Input.GetAxis("Horizontal");
            verticalInput = Input.GetAxis("Vertical");
            //We move the vehicle forward.
            //transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
            vehicleRb.AddRelativeForce(Vector3.forward * verticalInput * horsePower);
            //We turn the vehicle.
            transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
        }      
    }

    public bool IsOnGround()
    {
        wheelsOnGround = 0;
        foreach (WheelCollider wheel in allWheels)
        {
            if (wheel.isGrounded)
            {
                wheelsOnGround++;
            }
        }

        if (wheelsOnGround == 4)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
