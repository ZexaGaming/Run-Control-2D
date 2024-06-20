using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    private int totalKeys = 20; // Toplanmasý gereken toplam anahtar sayýsý
    private int collectedKeys = 0;

    public TextMeshProUGUI keyCountText; // Text UI elemanýna referans

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        UpdateKeyCountText();
    }

    public void CollectKey()
    {
        collectedKeys++;
        UpdateKeyCountText();
    }

    private void UpdateKeyCountText()
    {
        if (keyCountText != null)
        {
            keyCountText.text = "Keys: " + collectedKeys + "/" + totalKeys;
        }
    }

    public bool HasCollectedAllKeys()
    {
        return collectedKeys >= totalKeys;
    }
}
