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
            if (SceneUtility.GetBuildIndexByScenePath("Assets/Scenes/Level" + (GameManager.instance.Level) + ".unity") != -1)
                SceneManager.LoadSceneAsync("Level" + (GameManager.instance.Level));
            else
                SceneManager.LoadSceneAsync("Level"+ (GameManager.instance.Level-1));
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