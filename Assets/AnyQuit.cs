﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnyQuit : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Time.timeScale = 1;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.anyKey)
        {
            Application.Quit();
        }
	}
}
