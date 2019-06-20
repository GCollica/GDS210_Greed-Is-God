using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerFourScore : MonoBehaviour
{
    public static int scoreValue = 0;
    Text ScoreFour;

    // Start is called before the first frame update
    void Start()
    {
        ScoreFour = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        ScoreFour.text = "$" + scoreValue;
    }
}
