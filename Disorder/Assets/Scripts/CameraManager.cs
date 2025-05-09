using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{

    public Transform orientation;
    public Transform player;
    public Transform playerObject;
    public Rigidbody rigidBody;

    public float rotationSpeed;
    public Transform aim;
    public CameraStyle defaultStyle;
    public enum CameraStyle{
        Default,
        Aim
    }
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    private void Update()
    {
        //rotate orientation
        Vector3 viewDir = player.position - new Vector3(transform.position.x, player.position.y, transform.position.z);
       orientation.forward = viewDir.normalized;

        // rotate player object 
        if(defaultStyle == CameraStyle.Default){
        float horiInput = Input.GetAxis("Horizontal");
        float vertInput = Input.GetAxis("Vertical");
        Vector3 inputDir = orientation.forward * vertInput + orientation.right * horiInput;

        if(inputDir != Vector3.zero){
            playerObject.forward = Vector3.Slerp(playerObject.forward, inputDir.normalized, Time.deltaTime * rotationSpeed);
        }

        }

        else if (defaultStyle ==CameraStyle.Aim){
            Vector3 aimDirection = aim.position - new Vector3(transform.position.x,aim.position.y,transform.position.z);
            orientation.forward = aimDirection.normalized;

            player.forward = aimDirection.normalized;
        }
    }
}
