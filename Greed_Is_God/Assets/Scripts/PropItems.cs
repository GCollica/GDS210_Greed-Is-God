using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropItems : MonoBehaviour
{
    public GameObject coins;
    public GameObject coinsSpawnPoint;
    private int health = 2;

    // Update is called once per frame
    void Update()
    {
        if(health <= 0)
        {
            Instantiate(coins, coinsSpawnPoint.transform.position, Quaternion.identity);
            Destroy(this.gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Projectile"))
        {
            health--;
        }
    }
}
