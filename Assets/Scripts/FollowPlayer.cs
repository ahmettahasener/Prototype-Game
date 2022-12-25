using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Camera camTop;
    public Camera camLow;
    public GameObject player;
    [SerializeField] private bool changeCamera = true;
    [SerializeField] private Vector3 topCamera = new Vector3(0, 5, -7);
    [SerializeField] private Vector3 lowCamera = new Vector3(0, 2, 1);

    private void Start()
    {
        camTop.enabled = true;
        camLow.enabled = false;
    }
    // Update is called once per frame
    void LateUpdate()
        
    {
        camTop.transform.position = player.transform.position + topCamera;
        camLow.transform.position = player.transform.position + lowCamera;
        //Offset the camera behind the player by adding to the player's position.
        //transform.position = player.transform.position + topCamera;
    }

    public void ChooseCamera()
    {
        camTop.enabled = !camTop.enabled;
        if (camTop.enabled == true)
        {
            camTop.gameObject.SetActive(true);
        }
        else
        {
            camTop.gameObject.SetActive(false);
        }
        camLow.enabled = !camLow.enabled;
        if (camLow.enabled == true)
        {
            camLow.gameObject.SetActive(true);
        }
        else
        {
            camLow.gameObject.SetActive(false);
        }

        //changeCamera = !changeCamera;
        //if (changeCamera)
        //{
        //    transform.position = player.transform.position + topCamera;
        //}
        //else
        //{
        //    transform.position = player.transform.position + lowCamera;
        //}
    }
}
