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
    public static int health;
    public GameObject p1Heart1, p1Heart2, p1Heart3;

    public GameObject p1;
    private PManager p1PManager;
    
    // Start is called before the first frame update
    void Start()
    {
        p1PManager = p1.GetComponent<PManager>();

        health = 3;
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

        //health limit
        if (health == 3)
        {
            p1Heart1.gameObject.SetActive(true);
            p1Heart2.gameObject.SetActive(true);
            p1Heart3.gameObject.SetActive(true);
        }

        if (health == 2)
        {
            p1Heart1.gameObject.SetActive(true);
            p1Heart2.gameObject.SetActive(true);
            p1Heart3.gameObject.SetActive(false);
        }
        if (health == 1)
        {
            p1Heart1.gameObject.SetActive(true);
            p1Heart2.gameObject.SetActive(false);
            p1Heart3.gameObject.SetActive(false);
        }

        if (health == 0)
        {
            p1Heart1.gameObject.SetActive(false);
            p1Heart2.gameObject.SetActive(false);
            p1Heart3.gameObject.SetActive(false);
        }
    }
}
