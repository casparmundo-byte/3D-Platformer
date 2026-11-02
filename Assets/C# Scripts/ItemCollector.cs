using UnityEngine;
using TMPro;
public class NewMonoBehaviourScript : MonoBehaviour
{
    int Bullets = 0;
    
    [SerializeField] TMP_Text bulletsText;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bullets"))
        {
            float Bullets = 0f;

            Destroy(other.gameObject);
            Bullets++;
            bulletsText.text="Bullets:";
            
        }
    }
}
