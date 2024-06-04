using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class LevelManager : MonoBehaviour
{
    public TextMeshProUGUI loadingText;

    public void Start()
    {
        if (PlayerPrefs.HasKey("LevelIndex") == false) 
        {
            PlayerPrefs.SetInt("LevelIndex",1);
        }
        StartCoroutine(LoadingBar());
        LevelControl();
    }
    public void LevelControl()
    {
        int level = PlayerPrefs.GetInt("LevelIndex");
        SceneManager.LoadSceneAsync(level);
    }
    public IEnumerator LoadingBar()
    {
        while(true)
        {
            loadingText.text = "LOADING".ToString();
            yield return new WaitForSecondsRealtime(0.2f);
            loadingText.text = "LOADING .".ToString();
            yield return new WaitForSecondsRealtime(0.2f);
            loadingText.text = "LOADING ..".ToString();
            yield return new WaitForSecondsRealtime(0.2f);
            loadingText.text = "LOADING ...".ToString();
        }
    }
}
