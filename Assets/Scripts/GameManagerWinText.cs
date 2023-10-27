using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManagerWinText : MonoBehaviour
{
    // Score variables
    private int scoreLeft;
    private int scoreRight;

    // TMP variable
    public TextMeshProUGUI scoreText;

    // Start is called before the first frame update
    void Start()
    {
        scoreLeft = 0;
        scoreRight = 0;
    }

    // Update is called once per frame
    void Update()
    {
        // Update variables
        scoreLeft = ballPhys.scoreLeft;
        scoreRight = ballPhys.scoreRight;

        // Update text
        if (scoreLeft == 5)
        {
            scoreText.text = "Winner: Left";
        } else if (scoreRight == 5)
        {
            scoreText.text = "Winner: Right";
        } 
    }
}
