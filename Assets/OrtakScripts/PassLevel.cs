using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PassLevel : MonoBehaviour
{
    private int currentLevel;

    public void PassTheLevel()
    {
        currentLevel = SceneManager.GetActiveScene().buildIndex;

        if (currentLevel >= PlayerPrefs.GetInt("unlockedLevels"))
        {
            PlayerPrefs.SetInt("unlockedLevels", currentLevel+1);
        }
    }
}
