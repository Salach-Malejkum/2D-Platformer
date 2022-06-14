using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuScript : MonoBehaviour
{
    public GameObject pauseMenu;
    public Camera cam;
    private AudioSource audioSource;

    void Start()
    {
        audioSource = cam.GetComponent<AudioSource>();
    }

    public void PauseButton()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0.0f;
    }

    public void PausePlayButton()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1.0f;
    }

    public void PauseMuteButton()
    {
        audioSource.mute = !audioSource.mute;
    }

    public void PauseMenuButton()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene("Menu");
    }
}
