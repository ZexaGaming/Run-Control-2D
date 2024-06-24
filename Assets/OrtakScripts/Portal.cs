using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    public Transform targetTeleporter; // Hedef teleporter objesi
    public float cooldownTime = 1.0f; // Iþýnlanma sonrasý bekleme süresi
    private bool isOnCooldown = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!isOnCooldown && other.CompareTag("Player"))
        {
            StartCoroutine(TeleportWithCooldown(other.transform));
        }
    }

    private IEnumerator TeleportWithCooldown(Transform player)
    {
        // Iþýnlama
        player.position = targetTeleporter.position;

        // Cooldown baþlatma
        isOnCooldown = true;
        targetTeleporter.GetComponent<Portal>().isOnCooldown = true;

        // Bekleme süresi
        yield return new WaitForSeconds(cooldownTime);

        // Cooldown bitiþi
        isOnCooldown = false;
        targetTeleporter.GetComponent<Portal>().isOnCooldown = false;
    }
}
