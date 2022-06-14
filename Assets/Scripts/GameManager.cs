using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverObjects;
    public GameObject objects;
    public GameObject pauseMenu;
    public GameObject player;
    private ObjectsScript objectsScripts;
    private PlayerController playerController;
    // Start is called before the first frame update
    void Start()
    {
        objectsScripts = objects.GetComponent<ObjectsScript>();
        playerController = player.GetComponent<PlayerController>();
        gameOverObjects.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        CanPlayerAnim();
        IsGameEnd();
    }

    private IEnumerator WaitWithLoad(float time)
    {
        yield return new WaitForSeconds(time);
        SceneManager.LoadScene("Menu");
    }

    void CanPlayerAnim()
    {
        if (playerController != null)
        {
            if (pauseMenu.activeSelf)
            {
                playerController.canMove = false;
            }
            else
            {
                playerController.canMove = true;
            }
        }
    }

    void IsGameEnd()
    {
        if (player == null)
        {
            objectsScripts.canMove = false;
            gameOverObjects.SetActive(true);
            if (Input.anyKey)
            {
                StartCoroutine(WaitWithLoad(0.5f));
            }
        }
    }
}
