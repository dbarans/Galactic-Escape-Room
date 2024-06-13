using UnityEngine;

public class LaserCollision : MonoBehaviour
{
    [SerializeField] private Transform spawnPoint; // Punkt spawnu gracza

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.transform.position = spawnPoint.position; // Teleportuj gracza do punktu spawnu
            other.transform.rotation = spawnPoint.rotation; // Ustaw rotacjê gracza na rotacjê punktu spawnu
        }
    }
}
