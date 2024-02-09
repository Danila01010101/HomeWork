using System;
using UnityEngine;


namespace Assets.Homework3.Task2.Scripts
{
    [CreateAssetMenu(fileName = "ShopIconFactory", menuName = "ScriptableObjects/ShopIconFactory")]
    public class ShopIconFactory : IconFactory
    {
        public override Sprite GetIcon(Icon type)
        {
            switch (type)
            {
                case Icon.Coin:
                    Debug.Log("иконка для магазина изменена");
                    return CoinIcon;

                case Icon.Lightning:
                    Debug.Log("иконка для магазина изменена");
                    return LightningIcon;

                default:
                    throw new ArgumentException();
            }
        }
    }
}