using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace BreakIt.menu
{
    public class MainMenu : MonoBehaviour
    {

        private void Start()
        {
            Cursor.visible = true;
        }

        public void Continue()
        {
            SceneManager.LoadScene("Level"+GameManager.instance.Level);
        }

        public void LevelSelection()
        {
            SceneManager.LoadScene("LevelMenu");
        }

        public void Options()
        {
            SceneManager.LoadScene("OptionMenu");
        }

        public void QuitGame()
        {
            Application.Quit();
        }
    }
}