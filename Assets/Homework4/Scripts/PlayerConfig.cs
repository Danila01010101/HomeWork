using UnityEngine;

[CreateAssetMenu(fileName = "PlayerConfig", menuName = "Config/PlayerConfig")]
public class PlayerConfig : ScriptableObject
{
    [field: SerializeField, Range(0, 10)] public float Speed { get; private set; }
}