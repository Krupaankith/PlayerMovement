using UnityEngine;

public class ImpulseWall : MonoBehaviour
{
    [Range(100, 10000)]
    public float bounceHeight;

    void OnCollisionEnter(Collision collision)
    {
        GameObject bouncer = collision.gameObject;
        Rigidbody rb = bouncer.GetComponent<Rigidbody>();
        rb.AddForce(Vector3.up * bounceHeight);
    }
}
