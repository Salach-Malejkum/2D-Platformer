using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.UI;

public class MenuTest
{
    [SetUp]
    public void SetUp()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Menu");
    }

    [UnityTest]
    public IEnumerator MenuStartTest()
    {
        GameObject play = GameObject.Find("Play Button");
        GameObject settings = GameObject.Find("Settings Button");
        GameObject quit = GameObject.Find("Quit Button");
        yield return null;
        Assert.IsTrue(play.activeInHierarchy);
        Assert.IsTrue(settings.activeInHierarchy);
        Assert.IsTrue(quit.activeInHierarchy);
    }

    [UnityTest]
    public IEnumerator PlayButtonTest()
    {
        GameObject play = GameObject.Find("Play Button");
        var playInvoke = play.GetComponent<Button>();
        GameObject settings = GameObject.Find("Settings Button");
        GameObject quit = GameObject.Find("Quit Button");
        playInvoke.onClick.Invoke();
        yield return new WaitForSeconds(1);
        
        GameObject tutorial = GameObject.Find("Tutorial Button");
        GameObject infinity = GameObject.Find("Infinity Button");
        GameObject backSelect = GameObject.Find("Back Select Mode");

        Assert.IsFalse(play.activeInHierarchy);
        Assert.IsFalse(settings.activeInHierarchy);
        Assert.IsFalse(quit.activeInHierarchy);

        Assert.IsTrue(tutorial.activeInHierarchy);
        Assert.IsTrue(infinity.activeInHierarchy);
        Assert.IsTrue(backSelect.activeInHierarchy);
    }

    [UnityTest]
    public IEnumerator TutorialButtonTest()
    {
        GameObject play = GameObject.Find("Play Button");
        var playInvoke = play.GetComponent<Button>();
        GameObject settings = GameObject.Find("Settings Button");
        GameObject quit = GameObject.Find("Quit Button");
        playInvoke.onClick.Invoke();
        yield return new WaitForSeconds(1);
        
        GameObject tutorial = GameObject.Find("Tutorial Button");
        var tutorialInvoke = tutorial.GetComponent<Button>();
        GameObject infinity = GameObject.Find("Infinity Button");
        GameObject backSelect = GameObject.Find("Back Select Mode");
        tutorialInvoke.onClick.Invoke();
        yield return new WaitForSeconds(1);

        GameObject level1 = GameObject.Find("Level 1");
        GameObject level2 = GameObject.Find("Level 2");
        GameObject backTutorial = GameObject.Find("Back Tutorial");

        Assert.IsFalse(play.activeInHierarchy);
        Assert.IsFalse(settings.activeInHierarchy);
        Assert.IsFalse(quit.activeInHierarchy);

        Assert.IsFalse(tutorial.activeInHierarchy);
        Assert.IsFalse(infinity.activeInHierarchy);
        Assert.IsFalse(backSelect.activeInHierarchy);

        Assert.IsTrue(level1.activeInHierarchy);
        Assert.IsTrue(level2.activeInHierarchy);
        Assert.IsTrue(backTutorial.activeInHierarchy);
    }

    [UnityTest]
    public IEnumerator Level1Test()
    {
        GameObject play = GameObject.Find("Play Button");
        var playInvoke = play.GetComponent<Button>();
        playInvoke.onClick.Invoke();
        yield return new WaitForSeconds(1);
        
        GameObject tutorial = GameObject.Find("Tutorial Button");
        var tutorialInvoke = tutorial.GetComponent<Button>();
        tutorialInvoke.onClick.Invoke();
        yield return new WaitForSeconds(1);

        GameObject level1 = GameObject.Find("Level 1");
        var level1Invoke = level1.GetComponent<Button>();
        level1Invoke.onClick.Invoke();
        yield return new WaitForSeconds(1);

        var loadedScene = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
        Assert.AreEqual(loadedScene.name, "Level1");
    }

    [UnityTest]
    public IEnumerator Level2Test()
    {
        GameObject play = GameObject.Find("Play Button");
        var playInvoke = play.GetComponent<Button>();
        playInvoke.onClick.Invoke();
        yield return new WaitForSeconds(1);
        
        GameObject tutorial = GameObject.Find("Tutorial Button");
        var tutorialInvoke = tutorial.GetComponent<Button>();
        tutorialInvoke.onClick.Invoke();
        yield return new WaitForSeconds(1);

        GameObject level2 = GameObject.Find("Level 2");
        var level2Invoke = level2.GetComponent<Button>();
        level2Invoke.onClick.Invoke();
        yield return new WaitForSeconds(1);

        var loadedScene = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
        Assert.AreEqual(loadedScene.name, "Level2");
    }
}
