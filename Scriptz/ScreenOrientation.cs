using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenOrientation : MonoBehaviour
{
    [SerializeField] private float rotationSpeed = 5f;
    private float mouseX;
    private float mouseY;
    [SerializeField] private Camera cam;

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            mouseX = Input.GetAxis("Mouse X") * rotationSpeed;
            mouseY = Input.GetAxis("Mouse Y") * rotationSpeed;

            // Rotate camera around the origin (0,0,0) based on mouse input
            cam.transform.RotateAround(Vector3.zero, Vector3.up, mouseX);
            cam.transform.RotateAround(Vector3.zero, cam.transform.right, -mouseY);
        }
    }
}