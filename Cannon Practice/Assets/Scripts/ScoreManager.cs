﻿using UnityEngine;
using System.Collections;

public class ScoreManager : MonoBehaviour {

    public static int score;

    Text text;

	// Use this for initialization
	void Start () {
        text = GetComponent<Text>();
        score = 0;
	
	}
	
	// Update is called once per frame
	void Update () {
        guiText.text = "Score: " + score;
        if (score <= 83)
        {
            guiText.text = "You Win!";
        }
	}
}