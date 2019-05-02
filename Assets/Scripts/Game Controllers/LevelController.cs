using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour
{

    public void PlayLevel1()
    {
        SceneManager.LoadScene("Level1");
    }
    
    public void PlayLevel2()
    {
        SceneManager.LoadScene("Level2");
    }
    
    public void PlayLevel3()
    {
        SceneManager.LoadScene("Level3");
    }
    
    public void PlayLevel4()
    {
        SceneManager.LoadScene("Level4");
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}