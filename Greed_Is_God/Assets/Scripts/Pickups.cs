using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pickups : MonoBehaviour
{
    public GameObject door;
    public GameObject key;
    public Image UIKeyImage;

    public bool keyCollected;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Key"))
        {
            keyCollected = true;
            Destroy(key);
            //UIKeyImage.enabled = true;
        }

        if (keyCollected == true && other.CompareTag("Door"))
        {
            Destroy(door);
            keyCollected = false;
        }

        //if (UIKeyImage.enabled == true && other.CompareTag("Door"))
        //{
        //    Destroy(door);
        //    UIKeyImage.enabled = false;
        //}
    }
}
