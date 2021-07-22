﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public void LoadGame()
    {
        Time.timeScale = 1;
        StartCoroutine(start());  
    }

    IEnumerator start()
    {
        AnimationController.exit = true;
        yield return new WaitForSeconds(0.15f);
        SceneManager.LoadScene(1);
    }
}
