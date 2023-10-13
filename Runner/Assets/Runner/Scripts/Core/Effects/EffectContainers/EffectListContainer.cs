using System.Collections.Generic;

namespace Runner.Core
{
    public class EffectListContainer : IEffectContainer
    {
        private readonly EffectFactory _effectFactory;
        private readonly List<BaseEffect> _effects = new ();
        private bool _effectsChanged;


        public EffectListContainer(EffectFactory effectFactory)
        {
            _effectFactory = effectFactory;
        }
        
        void IEffectContainer.AddEffect(BaseEffectSettings settings)
        {
            var effect = _effectFactory.Create(settings);
            _effects.Add(effect);
            _effectsChanged = true;
        }
        
        void IEffectContainer.ApplyEffects(IEffectable effectable)
        {
            foreach (BaseEffect effect in _effects)
            {
                effect.ApplyEffect(effectable);
            }

            _effectsChanged = false;
        }
        
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