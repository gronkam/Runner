using Zenject;

namespace Runner.Core
{
    public class EffectFactory
    {
        [Inject] private DiContainer _container;

        public BaseEffect Create(BaseEffectSettings settings)
        {
            return (BaseEffect)_container.Instantiate(
                settings.EffectType,
                extraArgs: new object[] { settings });
        }
    }
}