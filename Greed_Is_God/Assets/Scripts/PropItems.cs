using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropItems : MonoBehaviour
{
    public GameObject coins;
    private int health = 3;

    // Update is called once per frame
    void Update()
    {
        if(health <= 0)
        {
            Instantiate(coins, transform.position, Quaternion.identity);
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
