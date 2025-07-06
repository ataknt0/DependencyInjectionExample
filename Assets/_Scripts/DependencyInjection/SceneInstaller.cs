using Zenject;

// This class configures dependency injection bindings for the scene using Zenject.
// It defines how dependencies (services/components) are resolved and injected across the scene.
public class SceneInstaller : MonoInstaller
{
    // This method is automatically called by Zenject during scene initialization.
    // Here, you declare all the dependency bindings that Zenject will manage.
    public override void InstallBindings()
    {
        // Bind ClickAudio component from the scene hierarchy as a singleton.
        // FromComponentInHierarchy() searches the active scene for the component.
        // AsSingle() ensures only one instance is created and shared.
        Container.Bind<ClickAudio>().FromComponentInHierarchy().AsSingle();

        // Bind ClickUI component similarly, guaranteeing a single shared instance.
        Container.Bind<ClickUI>().FromComponentInHierarchy().AsSingle();

        // Bind NonMonoExample, which is a pure C# class (not a MonoBehaviour),
        // as a singleton instance managed by the container.
        Container.Bind<NonMonoExample>().AsSingle();
    }
}
