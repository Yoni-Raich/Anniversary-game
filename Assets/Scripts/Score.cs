using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class Score : MonoBehaviour {

    public Transform player;
    public Text ScoreText;
    public GameObject PlusTen;
    public int points = 0;

    public void Start()
    {

        
        ScoreText.text = points.ToString();
    }
    public void ScorePoint(int score)
    {
        points += score;
        ScoreText.text = points.ToString();
    }
    
}
