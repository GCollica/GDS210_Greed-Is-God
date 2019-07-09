using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinBox : MonoBehaviour
{
    public bool Win = false;
    public GameObject WinScreen;

    private void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Win = true;          
            Debug.Log("congrats");
        }
    }
    private void Update()
    {
        if (Win == true)
        {
            gameObject.SetActive(true);
        }

    }
    
}
