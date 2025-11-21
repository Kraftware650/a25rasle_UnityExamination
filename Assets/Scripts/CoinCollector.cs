using UnityEngine;

public class CoinCollector : MonoBehaviour
{
    private int coinAmount = 0;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Coin"))
        {
            Destroy(other.gameObject);
            coinAmount++;
        }
    }
}
