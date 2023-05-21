using Common.Services;
using Zenject;

public class GlobalInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.Bind<ProviderCommutator>()
            .FromNew()
            .AsSingle();
    }
}