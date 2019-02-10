using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OptionsMenu : MonoBehaviour
{

    public Slider v_general;
    public Slider v_music;

    // Start is called before the first frame update
    void Start()
    {
        v_general.value = GameManager.instance.VolumeGeneral;
        v_music.value = GameManager.instance.VolumeMusic;
    }

    public void Apply()
    {
        GameManager.instance.VolumeGeneral = v_general.value;
        GameManager.instance.VolumeMusic = v_music.value;
        SceneManager.LoadScene("MainMenu");
    }

    public void Cancel()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
