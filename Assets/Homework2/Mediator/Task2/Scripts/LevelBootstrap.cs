using UnityEngine;

namespace Mediator
{
    public class LevelBootstrap : MonoBehaviour
    {
        [SerializeField] private Player _player;
        [SerializeField] private LevelInput _levelInput;
        [SerializeField] private LevelConfig _config;

        private void Awake()
        {
            _player.Initialize(_config.PlayerStartHealth, _config.LevelHealthBuff);
            _levelInput.Initialize(_player, _config.Damage, _config.HealingAmount);
        }
    }
}