using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform Player;

    void Update()
    {
        transform.position = Player.transform.position;
    }

}
