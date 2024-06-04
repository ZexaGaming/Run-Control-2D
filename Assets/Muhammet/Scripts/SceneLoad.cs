using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;

public class SceneLoad : MonoBehaviour
{
    public void MainScene()
    {
        SceneManager.LoadScene(2);
    }

    public void ExitGame()
    {
      
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }   
}

