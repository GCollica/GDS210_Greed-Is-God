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
    public GameObject heart1, heart2, heart3;

    public GameObject p1;
    private PManager p1PManager;
    
    // Start is called before the first frame update
    void Start()
    {
        p1PManager = p1.GetComponent<PManager>();

        health = 3;
        heart1.gameObject.SetActive(true);
        heart2.gameObject.SetActive(true);
        heart3.gameObject.SetActive(true);
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
        if (health > 3)
            health = 3;

        if (health == 2)
            heart3.gameObject.SetActive(false);

        if (health == 1)
            heart2.gameObject.SetActive(false);
            heart3.gameObject.SetActive(false);

        if (health == 0)
            heart1.gameObject.SetActive(false);
            heart2.gameObject.SetActive(false);
            heart3.gameObject.SetActive(false);
    }
}
