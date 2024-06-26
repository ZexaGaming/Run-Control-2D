using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    public Transform targetTeleporter; // Hedef teleporter objesi
    public float cooldownTime = 1.0f; // I��nlanma sonras� bekleme s�resi
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
        // I��nlama
        player.position = targetTeleporter.position;

        // Cooldown ba�latma
        isOnCooldown = true;
        targetTeleporter.GetComponent<Portal>().isOnCooldown = true;

        // Bekleme s�resi
        yield return new WaitForSeconds(cooldownTime);

        // Cooldown biti�i
        isOnCooldown = false;
        targetTeleporter.GetComponent<Portal>().isOnCooldown = false;
    }
}
