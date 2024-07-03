using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelComlateded : MonoBehaviour
{
    public GameObject LevelComplated;
    public CinemachineVirtualCamera vCam;

    private void Start()
    {

        LevelComplated.SetActive(false);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Player") && GameManager.instance.HasCollectedAllKeys())
        {
            
                Complated();

            
        }
      

    }

    void Complated()
    {

        LevelComplated.SetActive(true);

        if (vCam != null)
        {
            vCam.enabled = false;
        }
    }

}
