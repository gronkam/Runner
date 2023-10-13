namespace Runner.Core
{
    // Container for managing single effect, implementing the IEffectContainer interface
    public class SingleEffectContainer : IEffectContainer
    {
        private readonly EffectFactory _effectFactory; // Factory for creating effects
        private BaseEffect _effect; // effect
        private bool _effectsChanged; // Flag to indicate if the list of effects has changed

        // Constructor initializing the effect factory
        public SingleEffectContainer(EffectFactory effectFactory)
        {
            _effectFactory = effectFactory;
        }

        // Method to add an effect to the list
        void IEffectContainer.AddEffect(BaseEffectSettings settings)
        {
            _effect = _effectFactory.Create(settings);
            _effectsChanged = true;
        }

        // Method to apply all effects in the list to a given effectable entity
        void IEffectContainer.ApplyEffects(IEffectable effectable)
        {
            _effect?.ApplyEffect(effectable);

            _effectsChanged = false;
        }

        // Method to refresh all effects and remove expired ones from the list
        bool IEffectContainer.RefreshEffects()
        {
            if (_effect == null)
            {
                return _effectsChanged;
            }
            
            _effect.RefreshEffect();
            
            if (_effect.IsExpired)
            {
                _effect = null;
                _effectsChanged = true;
            }

            return _effectsChanged;
        }
    }
}