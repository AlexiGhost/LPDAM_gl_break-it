using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelButton : MonoBehaviour
{
    private int level;
    public int Level {
        get => level;
        set
        {
            level = value;
            GetComponentInChildren<Text>().text = level.ToString();
        } }
    
    public void LoadLevel()
    {
        SceneManager.LoadScene("Level" + level);
    }
}
