using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.UI;

public class PauseMenuTest
{
    [UnityTest]
    public IEnumerator PauseMenuStartLevel1Test()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Level1");
        yield return new WaitForSeconds(1);
        GameObject pause = GameObject.Find("Parent Pause");
        var pauseInvoke = pause.GetComponent<Button>();
        pauseInvoke.onClick.Invoke();
        yield return null;
        GameObject pauseMenu = GameObject.Find("Pause Menu");
        Assert.IsTrue(pauseMenu.activeInHierarchy);
    }

    [UnityTest]
    public IEnumerator PauseMenuResumeLevel1Test()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Level1");
        yield return new WaitForSeconds(1);
        GameObject pause = GameObject.Find("Parent Pause");
        var pauseInvoke = pause.GetComponent<Button>();
        pauseInvoke.onClick.Invoke();
        Time.timeScale = 1.0f;
        yield return new WaitForSeconds(0.1f);
        GameObject resume = GameObject.Find("Resume Button");
        var resumeInvoke = resume.GetComponent<Button>();
        resumeInvoke.onClick.Invoke();
        yield return new WaitForSeconds(0.1f);
        GameObject pauseMenu = GameObject.Find("Pause Menu");
        Assert.IsNull(pauseMenu);
    }

    [UnityTest]
    public IEnumerator PauseMenuMainMenuLevel1Test()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Level1");
        yield return new WaitForSeconds(1);
        GameObject pause = GameObject.Find("Parent Pause");
        var pauseInvoke = pause.GetComponent<Button>();
        pauseInvoke.onClick.Invoke();
        Time.timeScale = 1.0f;
        yield return new WaitForSeconds(0.1f);
        GameObject home = GameObject.Find("Home Button");
        var homeInvoke = home.GetComponent<Button>();
        homeInvoke.onClick.Invoke();
        yield return new WaitForSeconds(0.1f);
        
        var loadedScene = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
        Assert.AreEqual(loadedScene.name, "Menu");
    }

    [UnityTest]
    public IEnumerator PauseMenuStartLevel2Test()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Level2");
        yield return new WaitForSeconds(1);
        GameObject pause = GameObject.Find("Parent Pause");
        var pauseInvoke = pause.GetComponent<Button>();
        pauseInvoke.onClick.Invoke();
        yield return null;
        GameObject pauseMenu = GameObject.Find("Pause Menu");
        Assert.IsTrue(pauseMenu.activeInHierarchy);
    }

    [UnityTest]
    public IEnumerator PauseMenuResumeLevel2Test()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Level2");
        yield return new WaitForSeconds(1);
        GameObject pause = GameObject.Find("Parent Pause");
        var pauseInvoke = pause.GetComponent<Button>();
        pauseInvoke.onClick.Invoke();
        Time.timeScale = 1.0f;
        yield return new WaitForSeconds(0.1f);
        GameObject resume = GameObject.Find("Resume Button");
        var resumeInvoke = resume.GetComponent<Button>();
        resumeInvoke.onClick.Invoke();
        yield return new WaitForSeconds(0.1f);
        GameObject pauseMenu = GameObject.Find("Pause Menu");
        Assert.IsNull(pauseMenu);
    }

    [UnityTest]
    public IEnumerator PauseMenuMainMenuLevel2Test()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Level2");
        yield return new WaitForSeconds(1);
        GameObject pause = GameObject.Find("Parent Pause");
        var pauseInvoke = pause.GetComponent<Button>();
        pauseInvoke.onClick.Invoke();
        Time.timeScale = 1.0f;
        yield return new WaitForSeconds(0.1f);
        GameObject home = GameObject.Find("Home Button");
        var homeInvoke = home.GetComponent<Button>();
        homeInvoke.onClick.Invoke();
        yield return new WaitForSeconds(0.1f);
        
        var loadedScene = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
        Assert.AreEqual(loadedScene.name, "Menu");
    }
}
