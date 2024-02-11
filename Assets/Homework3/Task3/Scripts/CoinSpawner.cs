using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Assets.Homework3.Task3.Scripts
{
    public class CoinSpawner : MonoBehaviour
    {
        [SerializeField] private Coin _prefab;
        [SerializeField] private int _maxWeight = 4;
        [SerializeField] private List<Transform> _spawnPositions;

        private Dictionary<Vector3, bool> _spawnPoints;
        private CoinFactory _coinFactory;
        private SpawnWeightVisitor _spawnWeightVisitor;

        public void Initialize()
        {
            _spawnWeightVisitor = new SpawnWeightVisitor();
            _coinFactory = new CoinFactory(_prefab);
            _spawnPoints = _spawnPositions.ToDictionary(key => key.position, value => false);
            StartCoroutine(StartSpawning());
        }

        private void TrySpawnCoin()
        {
            if (IsAnyPointEmpty() && _spawnWeightVisitor.Weight < _maxWeight)
            {
                var choosenPoint = GetEmptySpawnPoint();
                var coin = _coinFactory.GetCoin(choosenPoint);
                _spawnWeightVisitor.Visit(coin);
                _spawnPoints[choosenPoint] = true;
            }
            else
                Debug.Log("Can`t spawn!");
        }

        private bool IsAnyPointEmpty() => _spawnPoints.Where(point => point.Value == false).Count() > 0;

        private Vector3 GetEmptySpawnPoint() => _spawnPoints.FirstOrDefault(point => point.Value == false).Key;

        private IEnumerator StartSpawning()
        {
            while (true)
            {
                yield return new WaitForSeconds(1f);
                TrySpawnCoin();
            }
        }
    }
}