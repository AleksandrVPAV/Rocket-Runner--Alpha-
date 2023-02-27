using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Obstacle : MonoBehaviour
{
    [SerializeField] private float _explosionForce;
    [SerializeField] private float _explosionRadius;
    [SerializeField] private Vector3 _expDirection;

    private float _lifetime = 2;

    public void BounceForward()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.AddExplosionForce(_explosionForce, transform.position + _expDirection, _explosionRadius);
        Destroy(gameObject, _lifetime);
    }
}
