using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class tekrar : MonoBehaviour
{
   
    public Button restartButton;

    void Start()
    {
        // Restart butonuna týklama olayýný ekleyin
        restartButton.onClick.AddListener(RestartGame);
    }

   public void RestartGame()
    {
        // Mevcut sahneyi yeniden yükle
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

