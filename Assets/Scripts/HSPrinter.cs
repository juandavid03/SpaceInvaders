﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HSPrinter : MonoBehaviour
{

    public Text highscore;
	// Use this for initialization
	void Start ()
    {
        highscore.text = PlayerPrefs.GetInt("HighScore").ToString();
	}
	
}
