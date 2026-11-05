using TMPro;
using UnityEngine;

public class ItemCollector : MonoBehaviour
{
    int Bullets = 0;

    [SerializeField] TMP_Text bulletsText;
    [SerializeField] AudioSource collectSound;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bullets"))
        {
            float Bullets = 0f;

            Destroy(other.gameObject);
            Bullets++;
            bulletsText.text = "Bullets:";

        }
    }
}
