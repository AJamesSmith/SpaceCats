﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour {

	public void StartButton()
    {
        SceneManager.LoadScene("MattLevel2", LoadSceneMode.Single);
    }
}
