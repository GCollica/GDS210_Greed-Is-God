using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "PlayerOne")
        {
            PlayerOneScore.scoreValue += 10;
            DestroyGameObject();
        }

        if (collision.gameObject.tag == "PlayerTwo")
        {
            PlayerTwoScore.scoreValue += 10;
            DestroyGameObject();
        }

        if (collision.gameObject.tag == "PlayerThree")
        {
            PlayerThreeScore.scoreValue += 10;
            DestroyGameObject();
        }

        if (collision.gameObject.tag == "PlayerFour")
        {
            PlayerFourScore.scoreValue += 10;
            DestroyGameObject();
        }
    }

    void DestroyGameObject()
    {
        Destroy(gameObject);
    }
}
