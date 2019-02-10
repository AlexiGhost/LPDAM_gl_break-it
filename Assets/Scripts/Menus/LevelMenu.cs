using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelMenu : MonoBehaviour
{
    public int levelCount;
    public GameObject levelPanel;
    public GameObject levelButton;

    private void Start()
    {
        for(int l=1; l <= levelCount; l++)
        {
            GameObject instance = Instantiate(levelButton, levelPanel.transform);
            instance.GetComponent<LevelButton>().Level = l;
            if(GameManager.instance.Level < l)
            {
                instance.GetComponent<Button>().interactable = false;
            }
        }
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
