using System;

namespace Mediator
{
    public class DefeatMediator
    {
        private DefeatPanel _defeatPanel;
        private Level _level;
        private Health _playerHealth;

        public DefeatMediator(DefeatPanel defeatPanel, Health playerHealth, Level level)
        {
            _defeatPanel = defeatPanel;
            _playerHealth = playerHealth;
            _level = level;
        }

        public void Subscribe()
        {
            _playerHealth.Death += _defeatPanel.Show;
        }

        public void Unsubscribe()
        {
            _playerHealth.Death -= _defeatPanel.Show;
        }

        public void RestartLevel()
        {
            _defeatPanel.Hide();
            _level.RestartLevel();
        }
    }
}