using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    public GameObject player;
    private int thrust = 25;
    Rigidbody rb;
    GreedGod greedGodScript;

    void Awake()
    {
        rb = this.gameObject.GetComponent<Rigidbody>();
        greedGodScript = FindObjectOfType<GreedGod>();       
    }

    void Update()
    {
        player = greedGodScript.currentGreedGod;
        transform.LookAt(player.transform);
    }

    private void LateUpdate()
    {
        rb.AddForce(transform.forward * thrust);
    }
}
