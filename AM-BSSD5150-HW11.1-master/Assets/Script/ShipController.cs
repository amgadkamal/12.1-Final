using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ShipController : MonoBehaviour
{
    [SerializeField] Transform spawnPoint;
    float speed = 10f;
    Rigidbody2D rb;
    private int enemiesss = 0;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        

    }


    void Update()
    {
        float move = Input.GetAxis("Horizontal");
        //   rb.velocity = Vector2.right * (move * speed);

        rb.rotation += -1 * move;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject pan = GameObject.Find("Panel");
            Image[] hudTrees = pan.GetComponentsInChildren<Image>();
            Destroy(hudTrees[hudTrees.Length - 1]);


            GameObject bullet =
                Instantiate(Resources.Load("bullet"), spawnPoint.position, transform.rotation) as GameObject;
            bullet.SetActive(true);
            GameObject scoreObj = GameObject.Find("ScoreObject");
            ScoreController scoreC = scoreObj.GetComponent<ScoreController>();


            
            
            GameObject scoree = GameObject.FindWithTag("enemy");
            ProjectileController scoreR = scoree.GetComponent<ProjectileController>();

            if (scoreObj != null)

            {
                scoreC.score++;
                if (scoreC.score > 3)
                {
                    SceneManager.LoadScene("End");
                    scoreC.msg = ("You Lose");

                }
            }

            if (scoreR.NoOfenemies==3)
            {
                SceneManager.LoadScene("End");
           
                scoreC.msg = ("You win");
            }

        }
    }

    
}