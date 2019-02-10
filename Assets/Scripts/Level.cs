using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level : MonoBehaviour
{
    public int level;
    public int lives = 3;

    public TextMeshProUGUI livesText;
    public GameObject loseText;
    public GameObject wonText;
    public bool isLevelWon;

    private int bricks;

    public static Level instance;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        instance = this;
        bricks = FindObjectsOfType<Brick>().Length;
        livesText.text = "Lives : " + lives;
    }

    public void DestroyBrick()
    {
        bricks--;
        if (bricks == 0)
            WinLevel();
    }

    private void WinLevel()
    {
        wonText.SetActive(true);
        Time.timeScale = 0.5f;
        isLevelWon = true;
        StartCoroutine(EndLevel());
    }

    private void LoseLive()
    {
        lives--;
        if (lives == 0)
        {
            LoseLevel();
        }
    }

    private void LoseLevel()
    {
        if (!isLevelWon)
        {
            loseText.SetActive(true);
            StartCoroutine(EndLevel());
        }
    }


    private IEnumerator EndLevel()
    {
        yield return new WaitForSecondsRealtime(3f);
        if (isLevelWon)
            GameManager.instance.NextLevel(level);
        else
            GameManager.instance.RestartLevel();
    }
}
