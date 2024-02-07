using UnityEngine.UI;

namespace Mediator
{
    public class Level
    {
        private LevelConfig _config;
        private Player _player;
        private HealthMediator _healthMediator;

        public Level(LevelConfig config, Player player)
        {
            _config = config;
            _player = player;
            _player.Initialize(_config.PlayerStartHealth, _config.LevelHealthBuff);
        }

        public void RestartLevel() => _player.ResetStats();
    }
}