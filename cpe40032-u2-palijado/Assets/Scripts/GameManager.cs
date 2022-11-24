using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int score = 0;
    private int lives = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddLives(int value)
    {
        // Counts the player's number of remaining lives
        lives += value;
        if (lives <= 0)
        {
            // Tells the user that the game is over
            Debug.Log("Game Over!");
        }
        else
        {
            // Displays the number of remaining lives 
            Debug.Log("Lives = " + lives);
        }
    }
    public void AddScore(int value)
    {
        // Counts and displays the score
        score += value;
        Debug.Log("Score = " + score);
    }
}
