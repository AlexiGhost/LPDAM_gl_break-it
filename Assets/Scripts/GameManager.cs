using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int lives;
    public float resetDelay = 1f;

    public TextMeshProUGUI livesText;
    public GameObject loseText;
    public GameObject wonText;

    private int bricks;

    public static GameManager instance;

    // Start is called before the first frame update
    void Start()
    {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);
        bricks = FindObjectsOfType<Brick>().Length;
    }

    public void DestroyBrick()
    {
        bricks--;
        Debug.Log(bricks);
        if (bricks == 0)
            WinLevel();
    }

    private void WinLevel()
    {
        wonText.SetActive(true);
        Time.timeScale = 0.25f;
    }
}
