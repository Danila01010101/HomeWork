using UnityEngine.UI;

namespace Mediator
{
    public class Healthbar
    {
        private Slider _slider;
        private float _healthValue;
        private float _maxHealth;

        public Healthbar(Slider slider, float startHealth, float maxHealth)
        {
            _slider = slider;
            _healthValue = startHealth;
            _maxHealth = maxHealth;
            _slider.maxValue = _maxHealth;
            _slider.value = _healthValue;
        }

        public void UpdateCurrentHealth(int newHealthValue)
        {
            _healthValue = newHealthValue;
            UpdateHealthbar();
        }

        public void UpdateMaxHealth(int newMaxHealthValue)
        {
            _maxHealth = newMaxHealthValue;
            _slider.maxValue = _maxHealth;
        }

        private void UpdateHealthbar()
        {
            _slider.value = _healthValue;
        }
    }
}