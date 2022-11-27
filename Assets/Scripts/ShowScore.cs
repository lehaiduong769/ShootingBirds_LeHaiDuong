using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowScore : MonoBehaviour
{
    private int score = 0;
    [SerializeField] private Text scoreTxt;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Bird b = collision.gameObject.GetComponent<Bird>();

        if (collision.gameObject.CompareTag("Fruit"))
        {
            if (b.isScore == false)
            {
                b.isScore = true;
                score = score + 10;
                scoreTxt.text = "Score: " + score;
                Destroy(collision.gameObject);
            }

        }
    }
}
