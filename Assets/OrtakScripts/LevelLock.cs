using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class LevelLock : MonoBehaviour
{
    [SerializeField] private Button[] buttons;

    private int unlockedLevels;
    private void Start()
    {
        unlockedLevels = PlayerPrefs.GetInt("unlockedLevels", 2);

        for (int i = 0; i < buttons.Length; i++) 
        {
            buttons[i].interactable = false;
        }

        for (int i = 0; i < unlockedLevels; i++)
        {
            buttons[i].interactable = true;
        }
    }


}