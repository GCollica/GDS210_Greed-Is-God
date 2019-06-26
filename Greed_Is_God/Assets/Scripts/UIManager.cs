using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    //keys 
    public Text p1KeycountText;
    private int p1KeycountValue;

    //gold
    public Text p1GoldcountText;
    private int p1GoldcountValue;

    //health
    public Image p1Healthcount;
    private int p1HealthValue;

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
        //key
        p1KeycountValue = p1PManager.keyCount;
        p1KeycountText.text = "x " + p1KeycountValue.ToString();

        //gold
        p1GoldcountValue = p1PManager.goldCount;
        p1GoldcountText.text = "$" + p1GoldcountValue.ToString();

        //health
    }
}
