using System.Collections.Generic;

namespace Runner.Core
{
    // Container for managing a list of effects, implementing the IEffectContainer interface
    public class EffectListContainer : IEffectContainer
    {
        private readonly EffectFactory _effectFactory; // Factory for creating effects
        private readonly List<BaseEffect> _effects = new(); // List of effects
        private bool _effectsChanged; // Flag to indicate if the list of effects has changed


        // Constructor initializing the effect factory
        public EffectListContainer(EffectFactory effectFactory)
        {
            _effectFactory = effectFactory;
        }

        // Method to add an effect to the list
        void IEffectContainer.AddEffect(BaseEffectSettings settings)
        {
            var effect = _effectFactory.Create(settings);
            _effects.Add(effect);
            _effectsChanged = true;
        }

        // Method to apply all effects in the list to a given effectable entity
        void IEffectContainer.ApplyEffects(IEffectable effectable)
        {
            foreach (BaseEffect effect in _effects)
            {
                effect.ApplyEffect(effectable);
            }

            _effectsChanged = false;
        }

        // Method to refresh all effects and remove expired ones from the list
        bool IEffectContainer.RefreshEffects()
        {
            for (int i = _effects.Count - 1; i >= 0; i--)
            {
                _effects[i].RefreshEffect();
                if (_effects[i].IsExpired)
                {
                    _effects.RemoveAt(i);
                    _effectsChanged = true;
                }
            }

            return _effectsChanged;
        }
    }
}