using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text p1KeycountText;
    private int p1KeycountValue;
    public GameObject p1;
    private PManager p1PManager;
    
    // Start is called before the first frame update
    void Start()
    {
        p1PManager = p1.GetComponent<PManager>();
    }

    // Update is called once per frame
    void Update()
    {
        p1KeycountValue = p1PManager.keyCount;
        p1KeycountText.text = "x " + p1KeycountValue.ToString();
    }
}
