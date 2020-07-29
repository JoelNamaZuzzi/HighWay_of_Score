using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScorePrint : MonoBehaviour
{
    [SerializeField] 
    private GameObject player;

    public Text scoreText;
    private int Score;
    
    void Start () {
        scoreText = GetComponent<Text>();
    }
    
    void Update()
    {
        Score = player.GetComponent<PlayerMove>()._score;
        scoreText.text = Score.ToString();
    }
}
