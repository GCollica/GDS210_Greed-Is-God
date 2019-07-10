using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    public GameObject player;
    private float thrust = 0.5f;
    Rigidbody rb;
    GreedGod greedGodScript;

    void Awake()
    {
        rb = this.gameObject.GetComponent<Rigidbody>();
        greedGodScript = FindObjectOfType<GreedGod>();       
    }

    void FixedUpdate()
    {
        LookAtTarget();
        MoveForward();
    }

    private void MoveForward()
    {
        rb.AddForce(transform.forward * thrust, ForceMode.VelocityChange);
    }

    private void LookAtTarget()
    {
        player = greedGodScript.currentGreedGod;
        transform.LookAt(player.transform);
    }
}
