using UnityEngine;

public class SpikeController : MonoBehaviour
{
    // Eðer diken ile bir nesne etkileþime geçerse
    private void OnTriggerEnter2D(Collider2D other)
    {
        // bu nesnenin tag'ý "Player" ise
        if (other.CompareTag("Player"))
        {
            // oyuncuyu öldür
            Debug.Log("Kullanýcý öldü.");
        }
    }
}