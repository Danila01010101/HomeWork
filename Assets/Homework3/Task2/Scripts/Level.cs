using UnityEngine.UI;

namespace Assets.Homework3.Task2.Scripts
{
    public class Level : IIconSwitcher
    {
        private Image _lightningIcon;
        private Image _coinIcon;

        public Level(Image lightningIcon, Image coinIcon)
        {
            _lightningIcon = lightningIcon;
            _coinIcon = coinIcon;
        }

        public void ChangeIcons(IconFactory factory)
        {
            _lightningIcon.sprite = factory.GetIcon(IconFactory.Icon.Lightning);
            _coinIcon.sprite = factory.GetIcon(IconFactory.Icon.Coin);
        }
    }
}