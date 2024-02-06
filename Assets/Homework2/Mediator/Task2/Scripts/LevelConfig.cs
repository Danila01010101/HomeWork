using UnityEngine;

namespace Mediator
{
    [CreateAssetMenu(fileName = "LevelConfig", menuName = "ScriptableObjects/LevelConfig")]
    public class LevelConfig : ScriptableObject
    {
        [SerializeField] private int _playerStartHealth;
        [SerializeField] private int _levelHealthBuffAmount;
        [SerializeField] private int _healingAmount;
        [SerializeField] private int _damage;

        public int PlayerStartHealth => _playerStartHealth;
        public int LevelHealthBuff => _levelHealthBuffAmount;
        public int HealingAmount => _healingAmount;
        public int Damage => _damage;
    }
}