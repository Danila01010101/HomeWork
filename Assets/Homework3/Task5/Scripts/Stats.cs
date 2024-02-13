using UnityEngine;

namespace Assets.Homework3.Task5.Scripts
{
    [CreateAssetMenu(fileName = "Stats", menuName = "ScriptableObjects/Stats", order = 1)]
    public class Stats : ScriptableObject
    {
        [SerializeField] private int _strenght;
        [SerializeField] private int _intelligence;
        [SerializeField] private int _agility;

        public int Strenght => _strenght;
        public int Intelligence => _intelligence;
        public int Agility => _agility;
    }
}