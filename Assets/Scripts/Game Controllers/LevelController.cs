﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{

    public void PlayGame()
    {
        Application.LoadLevel("Gameplay");
    }

    public void BackToMenu()
    {
        Application.LoadLevel("MainMenu");
    }
    
}
