using UnityEngine;
using Zenject;

namespace Assets.Homework4.Scripts
{
    public class GlobalInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            if (SystemInfo.deviceType == DeviceType.Desktop)
                Container.Bind<IInput>().To<DesctopInput>().AsSingle();
            else
                Container.Bind<IInput>().To<MobileInput>().AsSingle();
        }
    }
}