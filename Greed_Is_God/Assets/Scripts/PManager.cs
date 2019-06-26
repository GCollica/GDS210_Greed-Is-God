using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PManager : MonoBehaviour
{
    public int health = 5;
    public int goldCount;
    public int keyCount;
    public GameObject arrows;
    public GameObject spawnPoint;
    public GameObject player;

    public float rightTrigger; 

    public void Shoot()
    {           
        Instantiate(arrows, spawnPoint.transform.position, player.transform.rotation);                  
    }

    private void RateOfFire()
    {
        //
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Food"))
        {
            if(health <= 2)
            {
                health++;
            }

            Destroy(collision.gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            goldCount += 10;
            Destroy(other.gameObject);
        }
        if (other.gameObject.CompareTag("Key"))
        {
            keyCount++;
            Destroy(other.gameObject);
        }
        if (other.gameObject.CompareTag("Door") && keyCount >= 1)
        {
            keyCount--;
            Destroy(other.gameObject);
        }
    }

}
