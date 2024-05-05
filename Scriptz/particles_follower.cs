using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particles_follower : MonoBehaviour
{
    private Transform player;

    void Start()
    {
        player = GameObject.Find("Player(Clone)").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(player.position.x, player.position.y, player.position.z);
    }
}
