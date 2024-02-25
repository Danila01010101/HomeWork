using UnityEngine;
using Zenject;

namespace Assets.Homework4.Scripts
{
    public class GameplaySceneInstaller : MonoInstaller
    {
        [SerializeField] private Player _playerPrefab;
        [SerializeField] private Transform _spawnPoint;

        public override void InstallBindings()
        {
            Container.Bind<MovementHandler>().AsSingle().NonLazy();

            Player player = Container.InstantiatePrefabForComponent<Player>(_playerPrefab, _spawnPoint.position, Quaternion.identity, null);
            Container.BindInterfacesAndSelfTo<Player>().FromInstance(player).AsSingle();
        }
    }
}