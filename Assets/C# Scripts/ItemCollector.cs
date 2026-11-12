using UnityEngine;
using TMPro;

public class ItemCollector : MonoBehaviour
{
    int coins = 0;

    [SerializeField] TextMeshProUGUI coinText;
    [SerializeField] AudioSource collectSound;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            Destroy(other.gameObject);
            coins++;
            Debug.Log("Coins: " +  coins);
            coinText.text = "Coins: " + coins;
        }
    }
}
