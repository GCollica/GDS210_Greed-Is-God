using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PManager : MonoBehaviour
{
    public int health = 3;
    public bool invulnerable;
    public GameObject deathDrop;
    private DeathDropValue deathDV;

    public int goldCount;
    public int keyCount;
    float nextFire = 0f;
    public GameObject arrows;
    public GameObject spawnPoint;
    public GameObject player;

    private Vector3 playerSpawnPoint;

    public float rightTrigger;

    private GreedGod greedGod;

    private void Awake()
    {
        greedGod = FindObjectOfType<GreedGod>();
    }

    void Update()
    {
        greedGod = FindObjectOfType<GreedGod>();
        if(health <= 0)
        {
            Dead();
        }
    }

    void Dead()
    {
            gameObject.SetActive(false);
            goldCount = goldCount / 2;
            deathDV.deathDropValue = goldCount;
            Instantiate(deathDrop, player.transform.position, Quaternion.identity);
            Invoke("Spawn", 3);
    }

    void Spawn()
    {
        gameObject.SetActive(true);
        player.transform.position = greedGod.currentGreedGod.transform.position;
        invulnerable = true;
        Invoke("Invulnerability", 5);
    }

    void Invulnerability()
    {
        invulnerable = false;
    }

    public void Shoot()
    {                                 
        float fireRate = .25f;

        if (Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Instantiate(arrows, spawnPoint.transform.position, player.transform.rotation);          
        }
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

        if (collision.gameObject.CompareTag("Enemy") && invulnerable == false)
        {
            health -= 1;
            Debug.Log("Ouch");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            goldCount += 10;
            Destroy(other.gameObject);
        }
        if (other.gameObject.CompareTag("DeathDrop"))
        {
            goldCount += deathDV.deathDropValue;
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
