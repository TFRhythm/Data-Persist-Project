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

    public bool CheckHighScore(int newScore)
    {
        if (newScore > highScore)
        {
            highScore = newScore;
            PlayerPrefs.SetInt(HighScoreKey, highScore);
            PlayerPrefs.Save();
            return true;
        }

        return false;
    }

    public int GetHighScore()
    {
        return highScore;
    }

    public void ResetData()
    {
        PlayerPrefs.DeleteAll();
        PlayerPrefs.Save();
        highScore = 0;
    }
}
