using System;
using UnityEngine;

public class Baloon : MonoBehaviour
{
    public static Action<Baloon> BaloonBurst;
    public Enums.BaloonType Type { get; private set; }

    [SerializeField] private MeshRenderer _renderer;

    public void Initialize(BaloonParameters parameters)
    {
        Type = parameters.Type;
        _renderer.material = parameters.Material;
    }

    public void Burst()
    {
        BaloonBurst?.Invoke(this);
        Destroy(gameObject);
    }
}