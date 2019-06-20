using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerThreeScore : MonoBehaviour
{
    public static int scoreValue = 0;
    Text ScoreThree;

    // Start is called before the first frame update
    void Start()
    {
        ScoreThree = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        ScoreThree.text = "$" + scoreValue;
    }
}
