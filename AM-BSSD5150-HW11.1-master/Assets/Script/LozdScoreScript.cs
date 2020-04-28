using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LozdScoreScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject scoreObject = GameObject.Find("ScoreObject");
       
        ScoreController scoreCon = scoreObject.GetComponent<ScoreController>();
        
        int score = scoreCon.score;
        int enemyy = scoreCon.enemies;
        string msg = scoreCon.msg;
        
        Text scoreBox = GameObject.Find("Score").GetComponent<Text>();
        scoreBox.text = "Score:" + score.ToString();
        
        Text enemybox = GameObject.Find("Noofenemies").GetComponent<Text>();
        enemybox.text = "points:" + enemyy.ToString();

        Text msgbox = GameObject.Find("msg").GetComponent<Text>();
        msgbox.text = msg;
        
        
        
        GameObject.Find("BackButton").GetComponent<Button>().onClick.AddListener(goBack);
    }

    void goBack()
    {
        SceneManager.LoadScene("Menu");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
