using UnityEngine;
using UnityEngine.UI;

namespace Mediator
{
    public class LevelBootstrap : MonoBehaviour
    {
        [SerializeField] private Player _player;
        [SerializeField] private DefeatPanel _defeatPanel;
        [SerializeField] private Slider _slider;
        [SerializeField] private LevelInput _levelInput;
        [SerializeField] private LevelConfig _config;

        private DefeatMediator _defeatMediator;
        private HealthMediator _healthMediator;
        private Healthbar _healthbar;
        private Level _level;

        private void Awake()
        {
            _level = new Level(_config, _player);
            _healthbar = new Healthbar(_slider, _player.Health.HealthPoints, _player.Health.MaxHealth);
            _healthMediator = new HealthMediator(_player, _healthbar);
            _defeatMediator = new DefeatMediator(_defeatPanel, _player.Health, _level);
            _levelInput.Initialize(_player, _config.Damage, _config.HealingAmount);
            _defeatPanel.Initialize(_defeatMediator);
            _defeatMediator.Subscribe();
            _healthMediator.Subscribe();
        }

        private void OnDestroy()
        {
            _defeatMediator.Unsubscribe();
            _healthMediator.Unsubscribe();
        }
    }
}