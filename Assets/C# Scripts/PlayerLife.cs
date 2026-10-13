using UnityEngine;

public class PlayerLife : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy Body"))
        {
            Die();
        }
    }

    void Die
    {
        GetComponent<MeshRenderer>().enabled = false;
    }
}
