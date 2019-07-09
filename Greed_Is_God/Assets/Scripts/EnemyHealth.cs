using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    private int health = 2;

    private void Update()
    {
        if(health <= 0)
        {
            Destroy(this.gameObject);
            FindObjectOfType<AudioManager>().Play("EnemyDeath");
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Projectile"))
        {
            health--;
            FindObjectOfType<AudioManager>().Play("EnemyHit");
        }
    }
}
