using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_controller : MonoBehaviour
{
    [SerializeField] private float distanceY = 0.5f;
    [SerializeField] private float distanceZ = 1.5f;

    private Transform player;

    void Start()
    {
        player = GameObject.Find("Player(Clone)").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(player.position.x, player.position.y+distanceY, player.position.z+distanceZ);
    }
}
