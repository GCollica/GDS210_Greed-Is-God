using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerOneScore : MonoBehaviour
{
    public static int scoreValue = 0;
    Text ScoreOne;

    // Start is called before the first frame update
    void Start()
    {
        ScoreOne = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        ScoreOne.text = "$" + scoreValue;
    }
}
