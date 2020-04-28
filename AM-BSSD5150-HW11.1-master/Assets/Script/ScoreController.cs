using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class ScoreController : MonoBehaviour
{
    // Start is
    // called before the first frame update
    public int score = 0;
    public int enemies = 0;
    public string msg;
    public static bool created = false;



    private void Awake()
    {
        if (!created)
        {
            DontDestroyOnLoad(this);
            created = true;
        }
        else

        {
            Destroy(this.gameObject);

        }
    }

}