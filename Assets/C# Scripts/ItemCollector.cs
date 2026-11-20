using UnityEngine;
using TMPro;

public class ItemCollector : MonoBehaviour
{
    int coins = 0;

    [SerializeField] TextMeshProUGUI coinText;
    [SerializeField] AudioSource Pistol_ClipIn_05;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ammo"))
        {
            Destroy(other.gameObject);
            coins++;
            Debug.Log("Ammo: " +  coins);
            coinText.text = "Ammo: " + coins;
            Pistol_ClipIn_05.Play();
        }
    }
}
