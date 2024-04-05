using UnityEngine;
using Zenject;

namespace Assets.Homework4.Scripts
{
    public class GameplaySceneInstaller : MonoInstaller
    {
        [SerializeField] private Player _playerPrefab;
        [SerializeField] private PlayerConfig _playerConfig;
        [SerializeField] private Transform _spawnPoint;

        public override void InstallBindings()
        {
            BindMovementService();
            BindPlayer();
        }

        private void BindPlayer()
        {
            Container.Bind<PlayerConfig>().FromInstance(_playerConfig);
            Player player = Container.InstantiatePrefabForComponent<Player>(_playerPrefab, _spawnPoint.position, Quaternion.identity, null);
            Container.BindInterfacesAndSelfTo<Player>().FromInstance(player).AsSingle();
        }

        private void BindMovementService()
        {
            Container.Bind<MovementHandler>().AsSingle();
        }
    }
}