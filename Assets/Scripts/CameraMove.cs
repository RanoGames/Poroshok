using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    [SerializeField] float mouseSense = 1;
    [SerializeField] Transform Body;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    void Update()
    {
        Quaternion cameraRotation = transform.rotation;
        float yRotation = cameraRotation.eulerAngles.y;
        Quaternion newRotation = Quaternion.Euler(0, yRotation, 0);
        Body.transform.rotation = newRotation;
        
        transform.position = new Vector3(Body.position.x, Body.position.y + 0.5f, Body.position.z);
        Cursor.lockState = CursorLockMode.Locked;
        float rotateX = Input.GetAxis("Mouse X") * mouseSense;
        float rotateY = Input.GetAxis("Mouse Y") * mouseSense;
        rotateY = Mathf.Clamp(rotateY, -70, 70);
        Vector3 rotPlayer = transform.rotation.eulerAngles;
        rotPlayer.x -= rotateY;
        rotPlayer.z = 0;
        rotPlayer.y += rotateX;
        transform.rotation = Quaternion.Euler(rotPlayer);
        
    }
}
