using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_controller : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private float distanceY = 0.5f;
    [SerializeField] private float distanceZ = -1.5f;

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(player.position.x, player.position.y+distanceY, player.position.z+distanceZ);
    }
}
