using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target;
    public Vector3 offsetPos;
    public float moveSpeed = 5;
    public float smoothSpeed = 0.5f;

    Vector3 targetPos;

    // Update is called once per frame
    void Update()
    {
        MoveWithTarget();
    }

    void MoveWithTarget()
    {
        targetPos = target.position + offsetPos;
        transform.position = Vector3.Lerp(transform.position, targetPos, moveSpeed * Time.deltaTime);
    }
}
