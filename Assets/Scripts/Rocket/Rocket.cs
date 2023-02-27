using UnityEngine;

public class Rocket : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.TryGetComponent(out Obstacle obstacle))
        {
            obstacle.BounceForward();
        }
    }
}
