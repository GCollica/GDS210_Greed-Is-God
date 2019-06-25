using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PManager : MonoBehaviour
{
    private int health = 5;
    public GameObject arrows;
    public GameObject spawnPoint;

    public float rightTrigger; 

    void Update()
    {
        Shoot();                 
    }

    public void Shoot()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetAxis("RightTrigger") == 1)
        {
            Instantiate(arrows, spawnPoint.transform.position, Quaternion.identity);
        }
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
