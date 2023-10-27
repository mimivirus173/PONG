using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManagerRight : MonoBehaviour
{
    // Score variables
    private int scoreRight;

    // TMP variable
    public TextMeshProUGUI scoreText;

    // Start is called before the first frame update
    void Start()
    {
        scoreRight = 0;
    }

    // Update is called once per frame
    void Update()
    {
        scoreRight = ballPhys.scoreRight;
        scoreText.text = scoreRight.ToString();
    }
}
