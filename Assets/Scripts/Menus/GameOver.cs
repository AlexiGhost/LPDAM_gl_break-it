using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace BreakIt.menu
{
    public class GameOver : MonoBehaviour
    {

        private void Start()
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }

        public void ReplayGame()
        {
            SceneManager.LoadScene("Level1"); //TODO load last level
        }

        public void MainMenu()
        {
            SceneManager.LoadScene("MainMenu");
        }

        public void Hub()
        {
            SceneManager.LoadSceneAsync("Hub");
        }

        public void QuitGame()
        {
            Debug.Log("QUIT!");
            Application.Quit();
        }
    }
}