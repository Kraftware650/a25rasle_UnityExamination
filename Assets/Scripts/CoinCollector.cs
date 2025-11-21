using UnityEngine;

public class CoinCollector : MonoBehaviour
{
    [SerializeField] private TMPro.TextMeshProUGUI textBox;
    [SerializeField] private AudioSource coinCollect;
    private int coinAmount = 0;
    private string coinText = "Coins Collected: ";
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Coin"))
        {
            Destroy(other.gameObject);
            coinAmount++;
            textBox.text = coinText + coinAmount;
            coinCollect.Play();
        }
    }
}
