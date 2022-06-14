using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreScript : MonoBehaviour
{
    public int score = 0;
    public TextMeshPro scoreText;

    // Update is called once per frame
    void Update()
    {
        scoreText.SetText("Score: " + score);
    }
}
