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

    public int p1Health;
    public int p2Health;
    public int p3Health;
    public int p4Health;

    GreedGod greedGodScript;

    // Start is called before the first frame update
    void Awake()
    {
        P1ValueUpdate();
        P2ValueUpdate();
        P3ValueUpdate();
        P4ValueUpdate();
    }

    // Update is called once per frame
    void Update()
    {
        if (p1.activeInHierarchy == true)
        {
            P1ValueUpdate();
        }

        if (p2.activeInHierarchy == true)
        {
            P2ValueUpdate();
        }

        if (p3.activeInHierarchy == true)
        {
            P3ValueUpdate();
        }

        if (p4.activeInHierarchy == true)
        {
            P4ValueUpdate();
        }
    }
    

    void P1ValueUpdate()
    {
        p1Health = p1PManager.health;

        p1KeyCountValue = p1PManager.keyCount;
        p1KeyCountText.text = "x " + p1KeyCountValue.ToString();

        p1GoldCountValue = p1PManager.goldCount;
        p1GoldCountText.text = "$" + p1GoldCountValue.ToString();
        p1FinalScore.text = p1GoldCountValue.ToString();

        if (p1Health == 3)
        {
            p1Heart1.gameObject.SetActive(true);
            p1Heart2.gameObject.SetActive(true);
            p1Heart3.gameObject.SetActive(true);
        }

        if (p1Health == 2)
        {
            p1Heart1.gameObject.SetActive(true);
            p1Heart2.gameObject.SetActive(true);
            p1Heart3.gameObject.SetActive(false);
        }

        if (p1Health == 1)
        {
            p1Heart1.gameObject.SetActive(true);
            p1Heart2.gameObject.SetActive(false);
            p1Heart3.gameObject.SetActive(false);
        }

        if (p1Health == 0)
        {
            p1Heart1.gameObject.SetActive(false);
            p1Heart2.gameObject.SetActive(false);
            p1Heart3.gameObject.SetActive(false);
            Debug.Log("P1 Dead");
        }
    }

    void P2ValueUpdate()
    {
        p2Health = p2PManager.health;

        p2KeyCountValue = p2PManager.keyCount;
        p2KeyCountText.text = "x " + p2KeyCountValue.ToString();

        p2GoldCountValue = p2PManager.goldCount;
        p2GoldCountText.text = "$" + p2GoldCountValue.ToString();
        p2FinalScore.text = p2GoldCountValue.ToString();

        if (p2Health == 3)
        {
            p2Heart1.gameObject.SetActive(true);
            p2Heart2.gameObject.SetActive(true);
            p2Heart3.gameObject.SetActive(true);
        }

        if (p2Health == 2)
        {
            p2Heart1.gameObject.SetActive(true);
            p2Heart2.gameObject.SetActive(true);
            p2Heart3.gameObject.SetActive(false);
        }

        if (p2Health == 1)
        {
            p2Heart1.gameObject.SetActive(true);
            p2Heart2.gameObject.SetActive(false);
            p2Heart3.gameObject.SetActive(false);
        }

        if (p2Health == 0)
        {
            p2Heart1.gameObject.SetActive(false);
            p2Heart2.gameObject.SetActive(false);
            p2Heart3.gameObject.SetActive(false);
            Debug.Log("P2 Dead");
        }
    }

    void P3ValueUpdate()
    {
        p3Health = p3PManager.health;

        p3KeyCountValue = p3PManager.keyCount;
        p3KeyCountText.text = "x " + p3KeyCountValue.ToString();

        p3GoldCountValue = p3PManager.goldCount;
        p3GoldCountText.text = "$" + p3GoldCountValue.ToString();
        p3FinalScore.text = p3GoldCountValue.ToString();

        if (p3Health == 3)
        {
            p3Heart1.gameObject.SetActive(true);
            p3Heart2.gameObject.SetActive(true);
            p3Heart3.gameObject.SetActive(true);
        }

        if (p3Health == 2)
        {
            p3Heart1.gameObject.SetActive(true);
            p3Heart2.gameObject.SetActive(true);
            p3Heart3.gameObject.SetActive(false);
        }

        if (p3Health == 1)
        {
            p3Heart1.gameObject.SetActive(true);
            p3Heart2.gameObject.SetActive(false);
            p3Heart3.gameObject.SetActive(false);
        }

        if (p3Health == 0)
        {
            p3Heart1.gameObject.SetActive(false);
            p3Heart2.gameObject.SetActive(false);
            p3Heart3.gameObject.SetActive(false);
            Debug.Log("P3 Dead");
        }
    }
    void P4ValueUpdate()
    {
        p4Health = p4PManager.health;

        p4KeyCountValue = p4PManager.keyCount;
        p4KeyCountText.text = "x " + p4KeyCountValue.ToString();

        p4GoldCountValue = p4PManager.goldCount;
        p4GoldCountText.text = "$" + p4GoldCountValue.ToString();
        p4FinalScore.text = p4GoldCountValue.ToString();

        if (p4Health == 3)
        {
            p4Heart1.gameObject.SetActive(true);
            p4Heart2.gameObject.SetActive(true);
            p4Heart3.gameObject.SetActive(true);
        }

        if (p4Health == 2)
        {
            p4Heart1.gameObject.SetActive(true);
            p4Heart2.gameObject.SetActive(true);
            p4Heart3.gameObject.SetActive(false);
        }

        if (p4Health == 1)
        {
            p4Heart1.gameObject.SetActive(true);
            p4Heart2.gameObject.SetActive(false);
            p4Heart3.gameObject.SetActive(false);
        }

        if (p4Health == 0)
        {
            p4Heart1.gameObject.SetActive(false);
            p4Heart2.gameObject.SetActive(false);
            p4Heart3.gameObject.SetActive(false);
            Debug.Log("P4 Dead");
        }
    }
}
