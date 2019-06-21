using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pickups : MonoBehaviour
{
    public GameObject door;
    public GameObject key;
    public Image UIKeyImage;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Key"))
        {
            Destroy(key);
            UIKeyImage.enabled = true;
        }

        if (UIKeyImage.enabled == true && other.CompareTag("Door"))
        {
            Destroy(door);
            UIKeyImage.enabled = false;
        }
    }
}
