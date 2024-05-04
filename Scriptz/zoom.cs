using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zoom : MonoBehaviour
{
    public float zoomSpeed = 50f;
    public float minFOV = 10f;
    public float maxFOV = 150f;

    [SerializeField] private Camera cam;

    void Update()
    {
        float scroll = Input.GetAxis("Mouse ScrollWheel");
        float fov = cam.fieldOfView;
        fov += scroll * zoomSpeed;
        fov = Mathf.Clamp(fov, minFOV, maxFOV);
        cam.fieldOfView = fov;
    }
}

