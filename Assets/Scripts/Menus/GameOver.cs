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

        public void QuitGame()
        {
            Application.Quit();
        }
    }
}