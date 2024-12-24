using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;

public class Look : MonoBehaviour
{
    [SerializeField] Transform Camera;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    void Update()
    {
        Quaternion cameraRotation = Camera.transform.rotation;
        float yRotation = cameraRotation.eulerAngles.y;
        Quaternion newRotation = Quaternion.Euler(0, yRotation, 0);
        transform.rotation = newRotation;
    }
}
