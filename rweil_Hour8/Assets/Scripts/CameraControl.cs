using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    float rotationX = 0f;
    float rotationY = 0f;

    public float sensitivity = 15f;

    void Update()
    {
        rotationY += Input.GetAxis("Mouse X") * sensitivity;
        rotationX += Input.GetAxis("Mouse Y") * -1 * sensitivity;
        transform.localEulerAngles = new Vector3(rotationX, rotationY, 0);
    }
}
