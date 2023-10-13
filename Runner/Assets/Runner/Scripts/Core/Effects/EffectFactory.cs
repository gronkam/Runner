using Zenject;

namespace Runner.Core
{
    // Factory class for creating BaseEffect instances based on provided settings
    public class EffectFactory
    {
        [Inject] private DiContainer _container;  // Dependency injection container

        // Method to create a BaseEffect instance based on provided settings
        public BaseEffect Create(BaseEffectSettings settings)
        {
            return (BaseEffect)_container.Instantiate(
                settings.EffectType,
                extraArgs: new object[] { settings });
        }
    }
}