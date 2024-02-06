using UnityEngine;

namespace Mediator
{
    public class LevelInput : MonoBehaviour
    {
        private Player _player;
        private int _damage;
        private int _healingAmount;

        public void Initialize(Player player, int damage, int healingAmount)
        {
            _player = player;
            _damage = damage;
            _healingAmount = healingAmount;
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.D))
            {
                _player.Health.TakeDamage(_damage);
            }

            if (Input.GetKeyDown(KeyCode.H))
            {
                _player.Health.RestoreHealth(_healingAmount);
            }

            if (Input.GetKeyDown(KeyCode.L))
            {
                _player.LevelUp();
            }
        }
    }
}
