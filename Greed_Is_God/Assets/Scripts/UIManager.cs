using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    //keys 
    public Text p1KeyCountText;
    private int p1KeyCountValue;

    public Text p2KeyCountText;
    private int p2KeyCountValue;

    public Text p3KeyCountText;
    private int p3KeyCountValue;

    public Text p4KeyCountText;
    private int p4KeyCountValue;
    
    //gold
    public Text p1GoldCountText;
    private int p1GoldCountValue;

    public Text p2GoldCountText;
    private int p2GoldCountValue;

    public Text p3GoldCountText;
    private int p3GoldCountValue;

    public Text p4GoldCountText;
    private int p4GoldCountValue;

    //health
    public static int healthStat;
    public Image p1Heart1, p1Heart2, p1Heart3;

    public GameObject p1;
    public PManager p1PManager;

    public GameObject p2;
    public PManager p2PManager;

    public GameObject p3;
    public PManager p3PManager;

    public GameObject p4;
    public PManager p4PManager;

    // Start is called before the first frame update
    void Start()
    {
        //Health = GameObject.Find("Player_1").GetComponent<PManager>().health = 3;
        healthStat = p1PManager.health;
    }

    // Update is called once per frame
    void Update()
    {
        healthStat = p1PManager.health;

        //key
        p1KeyCountValue = p1PManager.keyCount ;
        p1KeyCountText.text = "x " + p1KeyCountValue.ToString();

        //gold
        p1GoldCountValue = p1PManager.goldCount;
        p1GoldCountText.text = "$" + p1GoldCountValue.ToString();

        p2GoldCountValue = p2PManager.goldCount;
        p2GoldCountText.text = "$" + p2GoldCountValue.ToString();

        p3GoldCountValue = p3PManager.goldCount;
        p3GoldCountText.text = "$" + p3GoldCountValue.ToString();

        p4GoldCountValue = p4PManager.goldCount;
        p4GoldCountText.text = "$" + p4GoldCountValue.ToString();

        //health loss
        if (healthStat == 3)
        {
            p1Heart1.gameObject.SetActive(true);
            p1Heart2.gameObject.SetActive(true);
            p1Heart3.gameObject.SetActive(true);
        }

        if (healthStat == 2)
        {
            Debug.Log("UI UPDATED");
            p1Heart1.gameObject.SetActive(true);
            p1Heart2.gameObject.SetActive(true);
            p1Heart3.gameObject.SetActive(false);
        }
        if (healthStat == 1)
        {
            p1Heart1.gameObject.SetActive(true);
            p1Heart2.gameObject.SetActive(false);
            p1Heart3.gameObject.SetActive(false);
        }

        if (healthStat == 0)
        {
            p1Heart1.gameObject.SetActive(false);
            p1Heart2.gameObject.SetActive(false);
            p1Heart3.gameObject.SetActive(false);
            Debug.Log("P1 Dead");
        }
    }
}
