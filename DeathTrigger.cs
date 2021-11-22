using UnityEngine;

public class DeathTrigger : MonoBehaviour
{
    [SerializeField] private Transform Player;
    [SerializeField] private Transform RespawnPoint;

    void OnTriggerEnter(Collider other)
    {
        Player.transform.position = RespawnPoint.transform.position;
    }
}
