using UnityEngine;

public class SpikeController : MonoBehaviour
{
    // E�er diken ile bir nesne etkile�ime ge�erse
    private void OnTriggerEnter2D(Collider2D other)
    {
        // bu nesnenin tag'� "Player" ise
        if (other.CompareTag("Player"))
        {
            // oyuncuyu �ld�r
            Debug.Log("Kullan�c� �ld�.");
        }
    }
}