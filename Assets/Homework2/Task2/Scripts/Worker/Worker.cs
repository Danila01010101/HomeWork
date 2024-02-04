using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(ObjectsChecker))]
public class Worker : MonoBehaviour
{
    [SerializeField] private WorkerConfig _config;

    private WorkerStateMachine _workerStateMachine;
    private WorkerMovement _workerMovement;
    private ObjectsChecker _objectsChecker;
    private Stamina _stamina;

    public WorkerMovement WorkerMovement => _workerMovement;
    public Stamina Stamina => _stamina;
    public ObjectsChecker ObjectsChecker => _objectsChecker;

    [field: SerializeField] public Workbench WorkPoint { get; private set; }
    [field: SerializeField] public Bed BedPoint { get; private set; }

    private void Awake()
    {
        Initialize();
    }

    public  void Initialize()
    {
        _workerMovement = new WorkerMovement(GetComponent<Rigidbody>(), _config.MoveSpeed);
        _stamina = new Stamina(_config.MaxStaminaValue);
        _objectsChecker = GetComponent<ObjectsChecker>();
        _objectsChecker.Initialize(_config.ObjectCheckRadius);
        _workerStateMachine = new WorkerStateMachine(this, _config);
    }

    private void Update()
    {
        _workerStateMachine.Update();
    }

    private void FixedUpdate()
    {
        _workerMovement.FixedUpdate();
    }
}