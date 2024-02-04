using UnityEngine;

[CreateAssetMenu(menuName = "Configs/WorkerConfig", fileName = "WorkerConfig")]
public class WorkerConfig : ScriptableObject
{
    [SerializeField] private float _moveSpeed;
    [SerializeField] private float _restingSpeed;
    [SerializeField] private float _fatigueRate;
    [SerializeField] private float _maxStaminaValue;
    [SerializeField] private float _objectCheckRadius;

    public float MoveSpeed => _moveSpeed;
    public float RestingSpeed => _restingSpeed;
    public float FatigueRate => _fatigueRate;
    public float MaxStaminaValue => _maxStaminaValue;
    public float ObjectCheckRadius => _objectCheckRadius;
}