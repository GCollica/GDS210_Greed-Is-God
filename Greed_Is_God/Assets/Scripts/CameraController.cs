using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target;
    public Vector3 offsetPos;
    public float moveSpeed = 5;
    public float smoothSpeed = 0.5f;

    public PManager pManager;

    Vector3 targetPos;

    void Awake()
    {
        pManager = gameObject.GetComponent<PManager>();
    }

    void Update()
    {
        MoveWithTarget();
    }

    void MoveWithTarget()
    {
        //Sets the Camera's position to the player + the offset value
        targetPos = target.position + offsetPos;

        //Sets the cameras target to the player position and smooths the movement  
        transform.position = Vector3.Lerp(transform.position, targetPos, moveSpeed * Time.deltaTime);
    }

    void GodGreed()
    {
        //targetPos = pManager.greedGod;
    }
}
