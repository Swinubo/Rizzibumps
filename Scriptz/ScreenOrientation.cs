/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenOrientation : MonoBehaviour
{
    private float rotationSpeed = 5.0f;
    private float horizontalInput;

    void Update()
    {
        // Rotate the camera based on input
        horizontalInput = Input.GetAxis("Mouse X") * rotationSpeed;
        transform.Rotate(Vector3.up, horizontalInput);
    }
}


using UnityEngine;

public class ScreenOrientation : MonoBehaviour
{
    private Vector3 dragOrigin;
    private Vector3 pos;
    private Vector3 move;
    private bool isDragging = false;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            dragOrigin = Input.mousePosition;
            isDragging = true;
        }

        if (Input.GetMouseButtonUp(0))
        {
            isDragging = false;
        }

        if (isDragging)
        {
            pos = Camera.main.ScreenToViewportPoint(dragOrigin - Input.mousePosition);
            move = new Vector3(pos.x * 2, 0, pos.y * 2);

            transform.Translate(move, Space.World);

            dragOrigin = Input.mousePosition;
        }
    }
}*/

using UnityEngine;

public class ScreenOrientation : MonoBehaviour
{
    public float rotationSpeed = 5.0f;
    private float mouseX;
    private float mouseY;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            mouseX = Input.GetAxis("Mouse X") * rotationSpeed;
            mouseY = Input.GetAxis("Mouse Y") * rotationSpeed;
        }

        transform.Rotate(Vector3.up, mouseX, Space.Self);
        transform.Rotate(Vector3.left, mouseY, Space.Self);
    }
}