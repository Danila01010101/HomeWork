using UnityEngine;
using Zenject;

namespace Assets.Homework4.Scripts
{
    public class Player : MonoBehaviour, IMovable
    {
        private MovementHandler _movementHandler;
        private float _speed;

        public bool HasReachedDestination()
        {
            throw new System.NotImplementedException();
        }

        public void SetDestination(Transform destinationPoint)
        {
            throw new System.NotImplementedException();
        }

        [Inject]
        private void Construct(MovementHandler movementHandler, PlayerConfig config)
        {
            _movementHandler = movementHandler;
            _speed = config.Speed;

            Debug.Log("Player Initialized!");
            Debug.Log("Player speed is " + _speed);
        }
    }
}