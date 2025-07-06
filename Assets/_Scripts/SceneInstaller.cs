using Zenject;
public class SceneInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.Bind<ClickAudio>().FromComponentInHierarchy().AsSingle();
        Container.Bind<ClickUI>().FromComponentInHierarchy().AsSingle();
        Container.Bind<NonMonoExample>().AsSingle();
    }
}