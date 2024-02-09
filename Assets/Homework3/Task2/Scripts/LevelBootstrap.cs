using UnityEngine;
using UnityEngine.UI;

namespace Assets.Homework3.Task2.Scripts
{
    public class LevelBootstrap : MonoBehaviour
    {
        [Header("Input")]
        [SerializeField] private LevelInput _levelInput;
        [Header("Icons")]
        [SerializeField] private Image _coinIcon;
        [SerializeField] private Image _lightningIcon;
        [Header("Factories")]
        [SerializeField] private ShopIconFactory _shopIconFactory;
        [SerializeField] private MenuIconFactory _menuIconFactory;

        private Level _level;
        private IconSwitcher _iconsSwitcher;

        private void Awake()
        {
            _level = new Level(_lightningIcon, _coinIcon);
            _iconsSwitcher = new IconSwitcher(_shopIconFactory, _menuIconFactory, _level, _levelInput);
        }
    }
}