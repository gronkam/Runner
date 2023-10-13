using UnityEngine;

namespace Runner.Core
{
    // Abstract class for basic effect settings, inherited by specific effect settings classes
    public abstract class BaseEffectSettings: ScriptableObject
    {
        // Duration for which the effect lasts
        [field: SerializeField]
        public float Duration { get; private set; }

        // Abstract property to be overridden by subclasses, representing the type of effect
        internal abstract System.Type EffectType { get; }
    }
    
    // Generic abstract class for effect settings, extending BaseEffectSettings
    public abstract class BaseEffectSettings<T>: BaseEffectSettings where T: BaseEffect
    {
        // Overrides EffectType to return the type of the effect
        internal override System.Type EffectType => typeof(T);
    }
}