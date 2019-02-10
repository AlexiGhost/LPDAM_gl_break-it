using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;

    private float timeScale;

    private void Update()
    {
        if(Input.GetButtonDown("Cancel"))
        {
            pauseMenu.SetActive(!pauseMenu.activeSelf);
            if (pauseMenu.activeSelf)
            {
                timeScale = Time.timeScale;
                Time.timeScale = 0;
            }
            else Time.timeScale = timeScale;
        }
    }

    public void Continue()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = timeScale;
    }

    public void LevelMenu()
    {
        SceneManager.LoadScene("LevelMenu");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
