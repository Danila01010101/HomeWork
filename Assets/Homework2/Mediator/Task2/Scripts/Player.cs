using UnityEngine;

namespace Mediator
{
    public class Player : MonoBehaviour
    {
        private Health _health;
        private int _healthBuffAmount;
        private int _currentLevel = 0;

        public Health Health => _health;

        public void Initialize(int maxHealth, int healthBuffAmount)
        {
            _health = new Health(maxHealth);

            _healthBuffAmount = healthBuffAmount;
        }

        public void LevelUp()
        {
            _currentLevel += 1;
            Debug.Log(string.Format("Level Up! Your current level - {0}!", _currentLevel));
            _health.IncreaseMaxHealth(_healthBuffAmount);
        }
    }
}