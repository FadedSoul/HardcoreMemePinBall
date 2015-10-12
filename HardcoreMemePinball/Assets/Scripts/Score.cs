﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour {
    private int _Score;
    private Text _ScoreText;
    public int PlayerScore
    {
        get { return _Score; }
        set { _Score = value; }
    }
	// Use this for initialization
	void Start () {
        SetScoreText();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void SetScoreText()
    {
        _ScoreText.text = "Score: " + _Score.ToString();
    }

}
