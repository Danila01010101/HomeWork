using System;
using UnityEngine;


namespace Assets.Homework3.Task2.Scripts
{
    [CreateAssetMenu(fileName = "MenuIconFactory", menuName = "ScriptableObjects/MenuIconFactory")]
    public class MenuIconFactory : IconFactory
    {
        public override Sprite GetIcon(Icon type)
        {
            switch (type)
            {
                case Icon.Coin:
                    Debug.Log("иконка для меню изменена");
                    return CoinIcon;

                case Icon.Lightning:
                    Debug.Log("иконка для меню изменена");
                    return LightningIcon;

                default:
                    throw new ArgumentException();
            }
        }
    }
}