using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private float distanceZ;
    [SerializeField] private float _offsetY;
    private Rocket _rocket;
    private Vector3 initialPosition;

    private void Start()
    {
        _rocket = FindObjectOfType<Rocket>();
        initialPosition = transform.position;
    }


    void LateUpdate()
    {
        Vector3 newPosition = initialPosition;
        newPosition.y = _rocket.transform.position.y + _offsetY;
        newPosition.z = _rocket.transform.position.z - distanceZ;
        transform.position = newPosition;
    }
}
