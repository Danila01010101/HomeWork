using UnityEngine;
using Zenject;

namespace Assets.Homework4.Scripts
{
    public class GlobalInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            if (SystemInfo.deviceType == DeviceType.Desktop)
                Container.BindInterfacesAndSelfTo<DesctopInput>().AsSingle();
            else
                Container.BindInterfacesAndSelfTo<MobileInput>().AsSingle();
        }
    }
}