using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerDeath : MonoBehaviour
{
    public GameObject deathScreen;
    public CinemachineVirtualCamera vCam;
    private void Start()
    {

        deathScreen.SetActive(false);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Die"))
        {
            Die();
        }
    }

    

    void Die()
    {

        deathScreen.SetActive(true);

        if (vCam != null)
        {
            vCam.enabled = false;
        }
      //  GetComponent<CharacterController>().enabled = false;
    }

  
}

