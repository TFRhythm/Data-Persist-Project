using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveData : MonoBehaviour
{
    private int highScore;
    private const string HighScoreKey = "HighScore";

    void Awake()
    {
        highScore = PlayerPrefs.GetInt(HighScoreKey, 0);
    }

    public bool CompareHighScore(int newScore)
    {
            Debug.Log("Old High Score: " + highScore + " New Score: " + newScore);
        if (newScore > highScore)
        {
            highScore = newScore;
            PlayerPrefs.SetInt(HighScoreKey, highScore);
            PlayerPrefs.Save();
            Debug.Log("New Score Saved");
            return true;
        }

            Debug.Log("New Score Not High Enough");
        return false;
    }

    public int GetHighScore()
    {
            Debug.Log("Get: " + highScore);
        return highScore;
    }

    public void ResetData()
    {
        Debug.Log("Reset");
        highScore = 0;
        PlayerPrefs.SetInt(HighScoreKey, 0);
        PlayerPrefs.Save();
    }
}
