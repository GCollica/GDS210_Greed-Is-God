using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    ////player 1
    public GameObject p1;
    public PManager p1PManager;

    //keys 
    public Text p1KeyCountText;
    private int p1KeyCountValue;

    //gold
    public Text p1GoldCountText;
    private int p1GoldCountValue;

    //health
    public Image p1Heart1, p1Heart2, p1Heart3;

    ////player 2
    public GameObject p2;
    public PManager p2PManager;

    //keys
    public Text p2KeyCountText;
    private int p2KeyCountValue;

    //gold
    public Text p2GoldCountText;
    private int p2GoldCountValue;

    //health
    public Image p2Heart1, p2Heart2, p2Heart3;

    ////player 3
    public GameObject p3;
    public PManager p3PManager;

    //keys
    public Text p3KeyCountText;
    private int p3KeyCountValue;

    //gold
    public Text p3GoldCountText;
    private int p3GoldCountValue;

    //health
    public Image p3Heart1, p3Heart2, p3Heart3;

    ////player 4
    public GameObject p4;
    public PManager p4PManager;
    
    //keys
    public Text p4KeyCountText;
    private int p4KeyCountValue;

    //gold
    public Text p4GoldCountText;
    private int p4GoldCountValue;

    //health
    public Image p4Heart1, p4Heart2, p4Heart3;

    //Win Screen
    public Text greedGodText;
    public Text p1FinalScore;
    public Text p2FinalScore;
    public Text p3FinalScore;
    public Text p4FinalScore;

    public static int healthStat;

    GreedGod greedGodScript;

    // Start is called before the first frame update
    void Start()
    {
        //Health = GameObject.Find("Player_1").GetComponent<PManager>().health = 3;
        healthStat = p1PManager.health;
        //greedGodText = greedGodScript.currentGreedGod;
    }

    // Update is called once per frame
    void Update()
    {
        healthStat = p1PManager.health;
        /*
        //key
        p1KeyCountValue = p1PManager.keyCount ;
        p1KeyCountText.text = "x " + p1KeyCountValue.ToString();

        p2KeyCountValue = p2PManager.keyCount;
        p2KeyCountText.text = "x " + p2KeyCountValue.ToString();

        p3KeyCountValue = p3PManager.keyCount;
        p3KeyCountText.text = "x " + p3KeyCountValue.ToString();

        p4KeyCountValue = p4PManager.keyCount;
        p4KeyCountText.text = "x " + p4KeyCountValue.ToString();

        //gold
        p1GoldCountValue = p1PManager.goldCount;
        p1GoldCountText.text = "$" + p1GoldCountValue.ToString();
        p1FinalScore.text = p1GoldCountValue.ToString();

        p2GoldCountValue = p2PManager.goldCount;
        p2GoldCountText.text = "$" + p2GoldCountValue.ToString();
        p2FinalScore.text = p2GoldCountValue.ToString();

        p3GoldCountValue = p3PManager.goldCount;
        p3GoldCountText.text = "$" + p3GoldCountValue.ToString();
        p3FinalScore.text = p3GoldCountValue.ToString();

        p4GoldCountValue = p4PManager.goldCount;
        p4GoldCountText.text = "$" + p4GoldCountValue.ToString();
        p4FinalScore.text = p4GoldCountValue.ToString();
        */
        if (gameObject.name == "Player_1")
        {
            Debug.Log("THISTHISHISISIIS");

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

        if (this.gameObject.name == "Player_2")
        {
            if (healthStat == 3)
            {
                p2Heart1.gameObject.SetActive(true);
                p2Heart2.gameObject.SetActive(true);
                p2Heart3.gameObject.SetActive(true);
            }

            if (healthStat == 2)
            {
                p2Heart1.gameObject.SetActive(true);
                p2Heart2.gameObject.SetActive(true);
                p2Heart3.gameObject.SetActive(false);
            }

            if (healthStat == 1)
            {
                p2Heart1.gameObject.SetActive(true);
                p2Heart2.gameObject.SetActive(false);
                p2Heart3.gameObject.SetActive(false);
            }

            if (healthStat == 0)
            {
                p2Heart1.gameObject.SetActive(false);
                p2Heart2.gameObject.SetActive(false);
                p2Heart3.gameObject.SetActive(false);
                Debug.Log("P2 Dead");
            }
        }

        if (this.gameObject.name == "Player_3")
        {
            if (healthStat == 3)
            {
                p3Heart1.gameObject.SetActive(true);
                p3Heart2.gameObject.SetActive(true);
                p3Heart3.gameObject.SetActive(true);
            }

            if (healthStat == 2)
            {
                p3Heart1.gameObject.SetActive(true);
                p3Heart2.gameObject.SetActive(true);
                p3Heart3.gameObject.SetActive(false);
            }

            if (healthStat == 1)
            {
                p3Heart1.gameObject.SetActive(true);
                p3Heart2.gameObject.SetActive(false);
                p3Heart3.gameObject.SetActive(false);
            }

            if (healthStat == 0)
            {
                p3Heart1.gameObject.SetActive(false);
                p3Heart2.gameObject.SetActive(false);
                p3Heart3.gameObject.SetActive(false);
                Debug.Log("P3 Dead");
            }
        }

        if (this.gameObject.name == "Player_4")
        {
            if (healthStat == 3)
            {
                p4Heart1.gameObject.SetActive(true);
                p4Heart2.gameObject.SetActive(true);
                p4Heart3.gameObject.SetActive(true);
            }

            if (healthStat == 2)
            {
                p4Heart1.gameObject.SetActive(true);
                p4Heart2.gameObject.SetActive(true);
                p4Heart3.gameObject.SetActive(false);
            }

            if (healthStat == 1)
            {
                p4Heart1.gameObject.SetActive(true);
                p4Heart2.gameObject.SetActive(false);
                p4Heart3.gameObject.SetActive(false);
            }

            if (healthStat == 0)
            {
                p4Heart1.gameObject.SetActive(false);
                p4Heart2.gameObject.SetActive(false);
                p4Heart3.gameObject.SetActive(false);
                Debug.Log("P4 Dead");
            }
        }
    }   
}
