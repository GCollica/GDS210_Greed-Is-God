using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PManager : MonoBehaviour
{
    private int health = 5;
    public GameObject arrows;
    public GameObject spawnPoint;

    void Update()
    {
        //For testing purposes only
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }

    }

    public void Shoot()
    {
        Instantiate(arrows, spawnPoint.transform.position, Quaternion.identity);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Food"))
        {
            if(health <= 4)
            {
                health++;
            }

            Destroy(collision.gameObject);
        }
    }

}
