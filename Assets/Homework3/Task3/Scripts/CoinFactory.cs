using UnityEngine;

namespace Assets.Homework3.Task3.Scripts
{
    public class CoinFactory
    {
        private Coin _coinPrefab;

        public CoinFactory(Coin prefab)
        {
            _coinPrefab = prefab;
        }

        public Coin GetCoin(Vector3 spawnPoint)
        {
            return MonoBehaviour.Instantiate(_coinPrefab, spawnPoint, new Quaternion(0, 0, 0, 0));
        }
    }
}