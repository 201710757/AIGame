using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score_Manager : MonoBehaviour
{
    Text scoreLabel;
    public static int score;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }
    void Awake()
    {
        scoreLabel = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        scoreLabel.text = Score_Manager.score.ToString();
    }
}
