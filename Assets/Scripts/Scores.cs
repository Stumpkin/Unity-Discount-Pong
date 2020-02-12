using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scores : MonoBehaviour
{

    public Text left;
    public Text right;
    private static int leftScore, rightScore;
    // Start is called before the first frame update
    void Start()
    {
        left.text = leftScore.ToString();
        right.text = rightScore.ToString();
    }

    
    void Update()
    {
        left.text = string.Format(leftScore.ToString(), "{0}");
        right.text = string.Format("{0}", rightScore.ToString());

        if (leftScore == 9)
        {
            left.color = Color.yellow;
        }

        if (rightScore == 9)
        {
            right.color = Color.yellow;
        }

        if (leftScore == 11)
        {
            left.color = Color.green;
        }

        if (rightScore == 11)
        {
            right.color = Color.green;
        }
    }
    
    
    public static void leftScored()
    {
        leftScore++;
    }

    public static void rightScored()
    {
        rightScore++;
    }
    
}
