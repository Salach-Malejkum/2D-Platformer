using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuScript : MonoBehaviour
{
    public Button playButton;
    public Button settingsButton;
    public Button quitButton;
    public Button infinityButton;
    public Button tutorialButton;
    public Button backSelectButton;
    public Button backTutorialButton;
    public Button level1Button;
    public Button level2Button;

    public void PlayButton()
    {
        tutorialButton.gameObject.SetActive(true);
        infinityButton.gameObject.SetActive(true);
        backSelectButton.gameObject.SetActive(true);

        playButton.gameObject.SetActive(false);
        settingsButton.gameObject.SetActive(false);
        quitButton.gameObject.SetActive(false);
    }

    public void SettingsButton()
    {
        // TO DO
    }

    public void QuitButton()
    {
        Application.Quit();
    }

    public void TutorialButton()
    {
        tutorialButton.gameObject.SetActive(false);
        infinityButton.gameObject.SetActive(false);
        backSelectButton.gameObject.SetActive(false);

        level1Button.gameObject.SetActive(true);
        level2Button.gameObject.SetActive(true);
        backTutorialButton.gameObject.SetActive(true);
    }

    public void InfinityButton()
    {
        // SceneManager.LoadScene("InfinityLevel");
    }

    public void BackSelectMode()
    {
        tutorialButton.gameObject.SetActive(false);
        infinityButton.gameObject.SetActive(false);
        backSelectButton.gameObject.SetActive(false);

        playButton.gameObject.SetActive(true);
        settingsButton.gameObject.SetActive(true);
        quitButton.gameObject.SetActive(true);
    }

    public void Level1()
    {
        SceneManager.LoadScene("Level1");
    }

    public void Level2()
    {
        SceneManager.LoadScene("Level2");
    }

    public void BackTutorialMode()
    {
        level1Button.gameObject.SetActive(false);
        level2Button.gameObject.SetActive(false);
        backTutorialButton.gameObject.SetActive(false);

        tutorialButton.gameObject.SetActive(true);
        infinityButton.gameObject.SetActive(true);
        backSelectButton.gameObject.SetActive(true);
    }
}
