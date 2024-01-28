using UnityEngine;

[CreateAssetMenu(fileName = "Ball", menuName = "ScriptableObjects/New Ball", order = 1)]
public class BaloonParameters : ScriptableObject
{
    public Enums.BaloonType Type;
    public Material Material;
}
