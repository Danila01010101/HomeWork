using UnityEngine;
using System;
using Mediator;

namespace Assets.Homework3.Task2.Scripts
{
    public class IconSwitcher : MonoBehaviour
    {
        private ShopIconFactory _shopIconFactory;
        private MenuIconFactory _menuIconFactory;
        private Level _level;
        private LevelType _currentLevel;

        public enum LevelType { Menu, Shop }

        public IconSwitcher(ShopIconFactory shopIconFactory, MenuIconFactory menuIconFactory, Level level, LevelInput input)
        {
            _shopIconFactory = shopIconFactory;
            _menuIconFactory = menuIconFactory;
            _level = level;
            input.CButtonPressed += SwitchIconsFabric;
            SwitchIconsFabric();
        }

        private void SwitchIconsFabric()
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