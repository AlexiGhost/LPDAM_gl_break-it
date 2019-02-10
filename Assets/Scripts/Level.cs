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
    public GameObject ballPrefab;
    public GameObject paddle;

    private bool isLevelWon;
    private int bricks;
    private AudioSource audioSource;

    public static Level instance;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        instance = this;
        bricks = FindObjectsOfType<Brick>().Length;
        bricks = GameObject.FindGameObjectsWithTag("brick").Length;
        livesText.text = "Vies : " + lives;
        audioSource = GetComponent<AudioSource>();
        audioSource.volume = GameManager.instance.VolumeGeneral * GameManager.instance.VolumeMusic;
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

    public void LoseLive()
    {
        lives--;
        livesText.text = "Vies : " + lives;
        if (lives == 0)
        {
            LoseLevel();
        } else {
            NewBall();
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

    private void NewBall()
    {
        Instantiate(ballPrefab, paddle.transform);
    }

    private IEnumerator EndLevel()
    {
        yield return new WaitForSecondsRealtime(3f);
        Time.timeScale = 1f;
        if (isLevelWon)
            GameManager.instance.NextLevel(level);
        else
            GameManager.instance.RestartLevel();
    }
}
