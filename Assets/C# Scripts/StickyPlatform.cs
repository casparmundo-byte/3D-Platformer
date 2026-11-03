using UnityEngine;

public class StickyPlatform : MonoBehaviour
{
    Vector3 lastPosition;
    Rigidbody playerRb;

    void Start()
    {
        lastPosition = transform.position;
    }

    void FixedUpdate()
    {
        Vector3 platformMove = transform.position - lastPosition;

        if (playerRb != null)
        {
            playerRb.MovePosition(playerRb.position + platformMove);
        }

        lastPosition = transform.position;
    }


    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            playerRb = collision.rigidbody;
        }
    }

    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            playerRb = null;
        }
    }
}
