using UnityEngine;

public class SpawnMover : MonoBehaviour
{
    [SerializeField] private float _offsetY;
    private Rocket _rocket;

    private void Start()
    {
        _rocket = FindObjectOfType<Rocket>();
    }
    private void Update()
    {
        transform.position = new Vector3(transform.position.x, _rocket.transform.position.y + _offsetY, transform.position.z);
    }
}
