using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PManager : MonoBehaviour
{
    public int health = 3;
    public int goldCount;
    public int keyCount;
    float nextFire = 0f;
    public GameObject arrows;
    public GameObject spawnPoint;
    public GameObject player;

    public List<int> scores;
    public int player1score;
    public int player2score;
    public int player3score;
    public int player4score;
    public int greedGod;

    public float rightTrigger;

    void Update()
    {
        StoreScore();
    }

    public void Shoot()
    {                                 
        float fireRate = .45f;

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

        if (collision.gameObject.CompareTag("Enemy"))
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

    void StoreScore() {
        if (gameObject.name == "Player_1")
        {
            player1score = goldCount;
        }

        if (gameObject.name == "Player_2")
        {
            player2score = goldCount; ;
        }

        if (gameObject.name == "Player_3")
        {    
            player3score = goldCount; ;
        }

        if (gameObject.name == "Player_4")
        {
            player4score = goldCount; ;
        }

        scores.Add(player1score);
        scores.Add(player2score);
        scores.Add(player3score);
        scores.Add(player4score);

        scores.Sort();


        for (int i = scores.Count; i-- > 0;)
        {
            greedGod = scores[1];
        }
    }

}
