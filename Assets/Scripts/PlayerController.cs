using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Private Variables
    public float speed;
    public float turnSpeed;
    private float horizontalInput;
    private float verticalInput;

    // Start is called before the first frame update
    void Start()
    {
        //gameManager.isGameActive = true;
    }

    // Update is called once per frame
    void Update()
    {
        //This is where we get player input.
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        //We move the vehicle forward.
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        //We turn the vehicle.
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }
}
