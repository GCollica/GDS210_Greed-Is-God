using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    Rigidbody projectileRb;
    private int thrust = 25;

    void Awake()
    {
        projectileRb = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        MoveForward();
    }

    void MoveForward()
    {
        projectileRb.velocity = transform.forward * thrust;
        //FindObjectOfType<AudioManager>().Play("Shooting");
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Food"))
        {
            Destroy(collision.gameObject);
            FindObjectOfType<AudioManager>().Play("FoodDeath");
        }

        Debug.Log(collision.gameObject.name);
        Destroy(this.gameObject);

    }
}
