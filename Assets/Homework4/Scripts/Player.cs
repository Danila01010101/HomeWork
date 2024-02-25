using UnityEngine;
using Zenject;

namespace Assets.Homework4.Scripts
{
    public class Player : MonoBehaviour
    {
        private MovementHandler _movementHandler;

        [Inject]
        private void Construct(MovementHandler movementHandler)
        {
            _movementHandler = movementHandler;

            Debug.Log("Player Initialized!");
        }
    }
}