using UnityEngine;

public class WorkerMovement : IMovable
{
    private Rigidbody _rigidbody;
    private Transform _destinationPoint;
    private Vector3 _position => _rigidbody.position;
    private float _moveSpeed = 3;
    private float _destinationThreshold = 3;
    private bool _hasReachedDestination = true;

    public WorkerMovement(Rigidbody rigidbody, float moveSpeed)
    {
        _rigidbody = rigidbody;
        _moveSpeed = moveSpeed;
    }

    public bool HasReachedDestination() => _hasReachedDestination;

    public void SetDestination(Transform destinationPoint)
    {
        _destinationPoint = destinationPoint;
        _hasReachedDestination = false;
    }

    public void FixedUpdate()
    {
        if (_hasReachedDestination)
        {
            return;
        }
        else if (Vector3.Distance(_position, _destinationPoint.position) < _destinationThreshold)
        {
            _hasReachedDestination = true;
        }

        Vector3 moveDirection = _destinationPoint.position - _position;
        Move(moveDirection);
    }

    private void Move(Vector3 direction)
    {
        _rigidbody.AddForce(direction.normalized * _moveSpeed * Time.fixedDeltaTime);
    }
}