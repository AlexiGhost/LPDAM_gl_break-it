using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    // Start is called before the first frame update
    void Start()
    {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);
        DontDestroyOnLoad(gameObject);
    }

    public void NextLevel(int level)
    {
        //Go to the next level, if there is none, go to main menu
        if (SceneUtility.GetBuildIndexByScenePath("Assets/Scenes/Level" + (level + 1) + ".unity") != -1)
            SceneManager.LoadSceneAsync("Level" + (level + 1));
        else
            SceneManager.LoadSceneAsync("MainMenu");
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
