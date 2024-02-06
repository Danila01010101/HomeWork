using System;
using UnityEngine;

namespace Mediator
{
    public class Health
    {
        private int _maxHealth;
        private int _amount;

        public Action Death;
        public Action HealthChanged;
        public Action MaxHealthChanged;

        public Health(int startHealth)
        {
            _maxHealth = startHealth;
            _amount = _maxHealth;
        }

        public int Amount
        {
            get => _amount;
            private set
            {
                if (value < 0 || value > _maxHealth)
                    throw new ArgumentOutOfRangeException();

                _amount = value;
            }
        }

        public void TakeDamage(int damage)
        {
            if (damage < 0)
                throw new ArgumentException();

            if (Amount - damage <= 0)
            {
                Amount = 0;
                Death?.Invoke();
            }
            else
            {
                Amount -= damage;
            }

            HealthChanged?.Invoke();
        }

        public void RestoreHealth(int healingAmount)
        {
            if (healingAmount < 0)
                throw new ArgumentException();

            if (Amount + healingAmount > _maxHealth)
            {
                Amount = _maxHealth;
            }
            else
            {
                Amount += healingAmount;
            }

            HealthChanged?.Invoke();
        }

        public void IncreaseMaxHealth(int value)
        {
            if (value < 0)
                throw new ArgumentException();

            _maxHealth += value;
            MaxHealthChanged?.Invoke();
        }
    }
}