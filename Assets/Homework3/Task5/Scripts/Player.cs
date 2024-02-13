using UnityEngine;

namespace Assets.Homework3.Task5.Scripts
{
    public class Player
    {
        private IStatsProvider _stats;

        private bool _isClassAdded = false;

        public Player(IStatsProvider stats)
        {
            _stats = stats;
            Debug.Log(string.Format("Final stats are - {0}:{1}:{2}", _stats.Strenght, _stats.Intelegence, _stats.Agility));
        }
    }
}