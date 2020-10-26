﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class canvasManager : MonoBehaviour
{
    public void QuitGame()
    {
        Application.Quit();
    }

    public void ResetLevel()
    {
        LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void NextLevel()
    {
        LoadScene((SceneManager.GetActiveScene().buildIndex+1)%SceneManager.sceneCountInBuildSettings);
    }

    public void LoadScene(int buildIndex)
    {
        SceneManager.LoadScene(buildIndex);
    }
}
