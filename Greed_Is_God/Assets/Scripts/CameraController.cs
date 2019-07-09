using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Vector3 offsetPos;
    public float moveSpeed = 5;
    public float smoothSpeed = 0.5f;
    private GameObject greedGod;
    Vector3 targetPos;
    private GreedGod greedGodScript;

    private void Awake()
    {
        greedGodScript = FindObjectOfType<GreedGod>();
    }

    void LateUpdate()
    {
        MoveWithTarget();
    }

    void MoveWithTarget()
    {
        //Sets the Camera's position to the player + the offset value
        greedGod = greedGodScript.currentGreedGod.gameObject;
        targetPos = greedGod.transform.position + offsetPos;

        //Sets the cameras target to the player position and smooths the movement  
        transform.position = Vector3.Lerp(transform.position, targetPos, moveSpeed * Time.deltaTime);
    }
}
