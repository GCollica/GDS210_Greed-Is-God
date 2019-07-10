using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PManager : MonoBehaviour
{
    public int health = 3;
    public bool invulnerable = false;

    public int goldCount;
    public int keyCount;
    float nextFire = 0f;
    public GameObject arrows;
    public GameObject spawnPoint;
    public GameObject player;

    private Vector3 playerSpawnPoint;

    public float rightTrigger;

    private GreedGod greedGod;
    private LivesManager lManager;

    public GameObject crown;
    public bool isGreedGod = false;


    private void Awake()
    {
        greedGod = FindObjectOfType<GreedGod>();
        lManager = FindObjectOfType<LivesManager>();
        
    }

    void Update()
    {
        if (health <= 0)
        {
            Dead();
        }
    }

    void Dead()
    {
            gameObject.SetActive(false);
            goldCount = goldCount / 2;
            Invoke("Spawn", 3);
    }

    void Spawn()
    {
        if(lManager.livesRemaining >= 1)
        {
            lManager.livesRemaining --;
            this.health = 3;
            invulnerable = true;
            gameObject.SetActive(true);
            if (player.transform.position != greedGod.currentGreedGod.transform.position)
            {
                player.transform.position = greedGod.currentGreedGod.transform.position;
            }
            Invoke("Invulnerability", 5);
        }       
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
            invulnerable = true;
            Invoke("Invulnerability", 2);
            Debug.Log("Ouch");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            goldCount += 10;
            Destroy(other.gameObject);
            FindObjectOfType<AudioManager>().Play("CoinPickup");
        }
        if (other.gameObject.CompareTag("Key"))
        {
            keyCount++;
            Destroy(other.gameObject);
            FindObjectOfType<AudioManager>().Play("KeyPickup");
        }
        if (other.gameObject.CompareTag("Door") && keyCount >= 1)
        {
            keyCount--;
            Destroy(other.gameObject);
            FindObjectOfType<AudioManager>().Play("DoorDeath");
        }
        if (other.gameObject.CompareTag("Bounds"))
        {
            this.gameObject.transform.position = greedGod.currentGreedGod.transform.position;
        }
    }
}
