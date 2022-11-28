using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Score : MonoBehaviour
{
    private float score = 0.0f;

    private int difficultyLevel = 1;
    private bool isDead = false;

    public DeathMenu deathMenu;
    public Text scoreText;


    // Update is called once per frame
    void Update()
    {
        if (isDead)
        {
            return;
        }

        score += Time.deltaTime * difficultyLevel;
        scoreText.text = ((int)score).ToString();
    }

    public void OnDeath()
    {
        isDead = true;
        if (PlayerPrefs.GetFloat("Highscore") < score)
        {
            PlayerPrefs.SetFloat("Highscore", score);
        }

        deathMenu.ToggleEndMenu(score);
    }
}