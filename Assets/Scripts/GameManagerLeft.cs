using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManagerLeft : MonoBehaviour
{
    // Score variables
    private int scoreLeft;

    // TMP variable
    public TextMeshProUGUI scoreText;

    // Start is called before the first frame update
    void Start()
    {
        scoreLeft = 0;
    }

    // Update is called once per frame
    void Update()
    {
        scoreLeft = ballPhys.scoreLeft;
        scoreText.text = scoreLeft.ToString();
    }
}
