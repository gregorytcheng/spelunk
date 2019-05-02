using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour
{
    public void PlayGame()
    {
        
    }
    
    public void PlayLevel1()
    {
        SceneManager.LoadScene("Level1");
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}