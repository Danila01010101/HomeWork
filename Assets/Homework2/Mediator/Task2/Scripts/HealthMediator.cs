namespace Mediator
{
    public class HealthMediator
    {
        private Player _player;
        private Healthbar _healthbar;

        public HealthMediator(Player player, Healthbar healthbar)
        {
            _player = player;
            _healthbar = healthbar;
        }

        public void Subscribe()
        {
            _player.Health.HealthChanged += _healthbar.UpdateCurrentHealth;
            _player.Health.MaxHealthChanged += _healthbar.UpdateMaxHealth;
        }

        public void Unsubscribe()
        {
            _player.Health.HealthChanged -= _healthbar.UpdateCurrentHealth;
            _player.Health.MaxHealthChanged -= _healthbar.UpdateMaxHealth;
        }
    }
}