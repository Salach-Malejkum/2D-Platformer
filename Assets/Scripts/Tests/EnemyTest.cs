using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class EnemyTest
{
    [UnityTest]
    public IEnumerator EnemyMovement1Test()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Level1");
        yield return new WaitForSeconds(1);
        GameObject enemy = GameObject.Find("Enemy");
        Vector3 pos = enemy.transform.position;
        yield return new WaitForSeconds(1);
        Assert.AreNotEqual(pos, enemy.transform.position);
    }

    [UnityTest]
    public IEnumerator EnemyMovement2Test()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Level2");
        yield return new WaitForSeconds(1);
        GameObject enemy = GameObject.Find("Enemy");
        Vector3 pos = enemy.transform.position;
        yield return new WaitForSeconds(1);
        Assert.AreNotEqual(pos, enemy.transform.position);
    }
}
