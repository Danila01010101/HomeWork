namespace Assets.Homework3.Task5.Scripts
{
    using System;

    public class RaceStats : IStatsProvider
    {
        private int _strenght;
        private int _intelligence;
        private int _agility;

        public RaceStats(Stats raceStats)
        {
            _strenght = raceStats.Strenght;
            _intelligence = raceStats.Intelligence;
            _agility = raceStats.Agility;
        }

        public int Strenght
        {
            get => _strenght;
        }

        public int Intelegence
        {
            get => _intelligence;
        }

        public int Agility
        {
            get => _agility;
        }
    }
}