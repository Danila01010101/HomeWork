using UnityEngine;

namespace Assets.Homework3.Task2.Scripts
{
    public abstract class IconFactory : ScriptableObject
    {
        [SerializeField] private Sprite _lightningIcon;
        [SerializeField] private Sprite _coinIcon;

        protected Sprite LightningIcon => _lightningIcon;
        protected Sprite CoinIcon => _coinIcon;

        public enum Icon { Lightning, Coin }

        public abstract Sprite GetIcon(Icon type);
    }
}