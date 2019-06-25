using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    Rigidbody projectileRb;
    private int thrust = 20;

    void Awake()
    {
        projectileRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        MoveForward();
    }

    void MoveForward()
    {
        projectileRb.AddForce(transform.forward * thrust);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Food"))
        {
            Destroy(collision.gameObject);
        }

        Destroy(this.gameObject);
    }
}
