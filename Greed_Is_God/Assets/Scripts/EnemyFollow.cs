using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    public GameObject player;
    public float thrust;
    Rigidbody rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void FixedUpdate()
    {
        rb.AddForce(transform.forward * thrust);
    }

    void Update()
    {
        transform.LookAt(player.transform);
    }
}
