using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    //keys 
    public Text p1KeyCountText;
    private int p1KeyCountValue;

    //gold
    public Text p1GoldCountText;
    private int p1GoldCountValue;

    //health
    public static int healthStat;
    public Image p1Heart1, p1Heart2, p1Heart3;

    public GameObject p1;
    public PManager p1PManager;
    
    // Start is called before the first frame update
    void Start()
    {
        //Health = GameObject.Find("Player_1").GetComponent<PManager>().health = 3;
        healthStat = p1PManager.health;
    }

    // Update is called once per frame
    void Update()
    {
        //key
        p1KeyCountValue = p1PManager.keyCount ;
        p1KeyCountText.text = "x " + p1KeyCountValue.ToString();

        //gold
        p1GoldCountValue = p1PManager.goldCount;
        p1GoldCountText.text = "$" + p1GoldCountValue.ToString();

        //health loss
        if (healthStat == 3)
        {
            p1Heart1.gameObject.SetActive(true);
            p1Heart2.gameObject.SetActive(true);
            p1Heart3.gameObject.SetActive(true);
        }

        if (healthStat == 2)
        {
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
