namespace Assets.Homework3.Task5.Scripts
{
    public class PassiveAbilityStats : IStatsProvider
    {
        private IStatsProvider _statsProvider;
        private Stats _stats;

        public int Strenght => _statsProvider.Strenght + _stats.Strenght;
        public int Intelegence => _statsProvider.Intelegence + _stats.Intelligence;
        public int Agility => _statsProvider.Agility + _stats.Agility;

        public PassiveAbilityStats(IStatsProvider provider, Stats stats)
        {
            _statsProvider = provider;
            _stats = stats;
        }
    }
}