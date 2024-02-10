using UnityEngine;

namespace Assets.Homework3.Task3.Scripts
{
    public class LevelBootstrap : MonoBehaviour
    {
        [SerializeField] private CoinSpawner _coinSpawner;

        private void Awake()
        {
            _coinSpawner.Initialize();
        }
    }
}