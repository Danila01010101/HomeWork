using UnityEngine;

namespace Assets.Homework3.Task2.Scripts
{
    public class LevelBootstrap : MonoBehaviour
    {
        [SerializeField] private ShopIconFactory _shopIconFactory;
        [SerializeField] private MenuIconFactory _menuIconFactory;

        private Level _level;
        private IIconSwitcher _iconsSwitcher;
        private LevelInput _input;

        private void Awake()
        {
            _level = new Level();

        }
    }
}