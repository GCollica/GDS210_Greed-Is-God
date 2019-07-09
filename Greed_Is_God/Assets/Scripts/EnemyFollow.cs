using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    public GameObject player;
    private int thrust = 15;
    Rigidbody rb;
    GreedGod greedGodScript;

    void Awake()
    {
        rb = this.gameObject.GetComponent<Rigidbody>();
        greedGodScript = FindObjectOfType<GreedGod>();       
    }

    void Update()
    {
        LookAtTarget();
        MoveForward();
    }

    private void MoveForward()
    {
        rb.AddForce(transform.forward * thrust);
        //Debug.Log("Moving Forward");
    }

    private void LookAtTarget()
    {
        player = greedGodScript.currentGreedGod;
        transform.LookAt(player.transform);
        //Debug.Log("Looking");
    }
}
