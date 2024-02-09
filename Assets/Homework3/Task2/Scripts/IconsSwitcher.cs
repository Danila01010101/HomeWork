using UnityEngine;
using System;
using Mediator;

namespace Assets.Homework3.Task2.Scripts
{
    public class IconsSwitcher : MonoBehaviour
    {
        private ShopIconFactory _shopIconFactory;
        private MenuIconFactory _menuIconFactory;
        private Level _level;
        private LevelType _currentLevel;

        public enum LevelType { Menu, Shop }

        public IconsSwitcher(ShopIconFactory shopIconFactory, MenuIconFactory menuIconFactory, Level level, LevelInput input)
        {
            _shopIconFactory = shopIconFactory;
            _menuIconFactory = menuIconFactory;
            _level = level;
            input.CButtonPressed += SwitchFabric;
        }

        private void SwitchFabric()
        {
            switch (_currentLevel)
            {
                case LevelType.Menu:
                    _level.ChangeIcons(_shopIconFactory);
                    _currentLevel = LevelType.Shop;
                    break;
                case LevelType.Shop:
                    _level.ChangeIcons(_menuIconFactory);
                    _currentLevel = LevelType.Menu;
                    break;
                default:
                    throw new ArgumentException();
            }
        }
    }
}