using System;
using UnityEngine;

namespace Assets.Homework3.Task5.Scripts
{
    [CreateAssetMenu(fileName = "LevelData", menuName = "ScriptableObjects/LevelData", order = 1)]
    public class LevelData : ScriptableObject
    {
        [Header("RaceStats")]
        [SerializeField] private Stats _orkStartStats;
        [SerializeField] private Stats _elfStartStats;
        [SerializeField] private Stats _humanStartStats;

        [Header("ClassStats")]
        [SerializeField] private Stats _thiefStats;
        [SerializeField] private Stats _mageStats;
        [SerializeField] private Stats _barbarianStats;

        [Header("AbilityStats")]
        [SerializeField] private Stats _inteligenceStats;
        [SerializeField] private Stats _strenghtStats;
        [SerializeField] private Stats _agilityStartStats;

        public Stats OrkStartStats => _orkStartStats;
        public Stats ElfStartStats => _elfStartStats;
        public Stats HumanStartStats => _humanStartStats;
        public Stats ThiefStats => _thiefStats;
        public Stats MageStats => _mageStats;
        public Stats BarbarianStats => _barbarianStats;
        public Stats InteligenceStats => _inteligenceStats;
        public Stats StrenghtStats => _strenghtStats;
        public Stats AgilityStartStats => _agilityStartStats;
    }
}