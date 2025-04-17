using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountScore : MonoBehaviour
{
    public UnityEngine.UI.Text scoreText; // UI Text component to display the score
    private int score = 0; // Variable to store the score
    public void Update()
    {
        scoreText.text = score.ToString(); // Update the UI Text with the current score
    }
    public void AddScore(int val)
    {
        score += val;  
    }   
}
