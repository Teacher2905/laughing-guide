using UnityEngine;

public class TeleportEnter : MonoBehaviour
{
    [SerializeField] private Transform teleportExit;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != "Ground")
        {
            collision.transform.position = teleportExit.position;
        }
    }
}
