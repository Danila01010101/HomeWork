using System;
using UnityEngine;

namespace Mediator
{
    public class Health
    {
        private int _maxHealth;
        private int _healthPoints;
        private int _startHealth;

        public Action Death;
        public Action<int> HealthChanged;
        public Action<int> MaxHealthChanged;
        public int MaxHealth => _maxHealth;

        public Health(int startHealth)
        {
            _maxHealth = startHealth;
            _healthPoints = _maxHealth;
            _startHealth = _maxHealth;
        }

        public int HealthPoints
        {
            get => _healthPoints;
            private set
            {
                if (value < 0 || value > _maxHealth)
                    throw new ArgumentOutOfRangeException();

                _healthPoints = value;
            }
        }

        public void TakeDamage(int damage)
        {
            if (damage < 0)
                throw new ArgumentException();

            if (HealthPoints - damage <= 0)
            {
                HealthPoints = 0;
                Death?.Invoke();
            }
            else
            {
                HealthPoints -= damage;
            }

            HealthChanged?.Invoke(HealthPoints);
        }

        public void RestoreHealth(int healingAmount)
        {
            if (healingAmount < 0)
                throw new ArgumentException();

            if (HealthPoints + healingAmount > _maxHealth)
            {
                HealthPoints = _maxHealth;
            }
            else
            {
                HealthPoints += healingAmount;
            }

            HealthChanged?.Invoke(HealthPoints);
        }

        public void IncreaseMaxHealth(int value)
        {
            if (value < 0)
                throw new ArgumentException();

            _maxHealth += value;
            MaxHealthChanged?.Invoke(_maxHealth);
        }

        public void Reset()
        {
            _maxHealth = _startHealth;
            HealthPoints = _maxHealth;

            HealthChanged?.Invoke(HealthPoints);
            MaxHealthChanged?.Invoke(MaxHealth);
        }
    }
}