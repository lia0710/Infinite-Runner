using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameControlScript : MonoBehaviour
{
    public static GameControlScript instance;
    public float scrollSpeed = -6f;
    public bool gameOver = false;

    public Text scoreText;
    public Text healthText;

    public int score = 0;
    public int health = 3;

    void Awake()
    {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);
    }

    void Update()
    {
        if (gameOver && Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene(0);
        }
    }

    public void Scored(int points)
    {
        if (gameOver)
            return;
        score = score + points;
        scoreText.text = "Score: " + score.ToString();
    }

    public void Damaged()
    {
        health--;
        healthText.text = "Health: " + health.ToString();
        if (health <= 0)
        {
            Died();
        }
    }

    public void Died()
    {
        gameOver = true;
        Application.LoadLevel(2);
    }

}
