﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
public void PlayGame()
    {
        if (OVRInput.Get(OVRInput.Button.One))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

    }
public void QuitGame()
    {
        if (OVRInput.Get(OVRInput.Button.One))
        {
            Debug.Log("QUIT!");
            Application.Quit();
        }
    }
}
