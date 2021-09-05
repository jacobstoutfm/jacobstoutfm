using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    /public static bool paused = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P)) //Common key would be ESC or P, replace if needed
        {
            if (paused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
        
    }

    public void Resume ()
    {
        pauseOverlay.SetActive(false);
        Time.timeScale = 1f; //Resumes gameplay
        paused = false; 
    }

    public void Pause()
    {
        pauseOverlay.SetActive(true);
        Time.timeScale = 0f; //Stops gameplay
        paused = true; 
    }

    public void ReturnToMenu ()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");

    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
