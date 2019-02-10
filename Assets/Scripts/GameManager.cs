using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public float VolumeGeneral
    {
        get => (PlayerPrefs.GetInt("v_general", 100) / 100f);
        set => PlayerPrefs.SetInt("v_general", Mathf.FloorToInt(value * 100));
    }
    public float VolumeMusic
    {
        get => (PlayerPrefs.GetInt("v_music", 100) / 100f);
        set => PlayerPrefs.SetInt("v_music", Mathf.FloorToInt(value * 100));
    }
    public int Level
    {
        get => PlayerPrefs.GetInt("level", 1);
        set => PlayerPrefs.SetInt("level", value);
    }

    // Start is called before the first frame update
    void Start()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else if (instance != this)
            Destroy(this);
    }

    public void NextLevel(int level)
    {
        if (level == Level)
            Level = Level + 1;

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
