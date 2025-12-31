using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResetData : MonoBehaviour
{
    public Text HighScoreText;
    [SerializeField] private SaveData save;
    public void ResetPlayerPrefs()
    {
        save.ResetData();
        HighScoreText.text = $"High Score : {save.GetHighScore()}";

    }
}
