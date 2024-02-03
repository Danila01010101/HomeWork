using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Worker : MonoBehaviour
{
    [field: SerializeField] public Transform WorkPoint { get; private set; }
    [SerializeField] private Transform _housePoint;

    private WorkerStateMachine _workerStateMachine;
    private Rigidbody _rigidbody;
    private float _moveSpeed = 5f;

    private void Initialize()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    public void Move(Vector3 direction)
    {
        _rigidbody.AddForce(direction.normalized * _moveSpeed);
    }
}