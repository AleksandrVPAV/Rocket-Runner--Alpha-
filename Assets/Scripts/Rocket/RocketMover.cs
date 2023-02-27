using UnityEngine;

[RequireComponent(typeof(Rocket))]
public class RocketMover : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;
    [SerializeField] private float _distanceBetweenLines;
    
    private int _startPosition = 2;
    private int _lineToMove;

    public float MoveSpeed { get { return _moveSpeed; }}

    private void Start()
    {
        _lineToMove = _startPosition;
    }
    

    void Update()
    {

        transform.Translate(new Vector3(0, _moveSpeed,0) * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.A))
        {
            if (_lineToMove > 0)
            {
                _lineToMove--;
            }
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            if (_lineToMove < 4)
            {
                _lineToMove++;
            }
        }

        Vector3 targetPosition = transform.position.z * transform.forward + transform.position.y * transform.up;

        if (_lineToMove == 0)
        {
            targetPosition += Vector3.left * 2 * _distanceBetweenLines;
        }
        else if (_lineToMove == 1)
        {
            targetPosition += Vector3.left * _distanceBetweenLines;
        }
        else if (_lineToMove == 3)
        {
            targetPosition += Vector3.right * _distanceBetweenLines;
        }
        else if (_lineToMove == 4)
        {
            targetPosition += Vector3.right * 2 * _distanceBetweenLines;
        }

        transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime * _moveSpeed);
    }
}