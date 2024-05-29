using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManagement : MonoBehaviour
{
    public TextMeshProUGUI scoreBoard;
    public static int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreBoard.text = "SCORE : " + score.ToString();
    }
}
