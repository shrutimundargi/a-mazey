﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Funtionality : MonoBehaviour
{
  public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        Debug.Log("Quit!!");
        Application.Quit();
    }

    public void MainOpt()
    {
        SceneManager.LoadScene(0);
    }
}
