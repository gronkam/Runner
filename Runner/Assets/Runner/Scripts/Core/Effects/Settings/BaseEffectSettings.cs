using UnityEngine;

namespace Runner.Core
{
    public abstract class BaseEffectSettings: ScriptableObject
    {
        [field: SerializeField]
        public float Duration { get; private set; }

        internal abstract System.Type EffectType { get; }
    }
    
    public abstract class BaseEffectSettings<T>: BaseEffectSettings where T: BaseEffect
    {
        internal override System.Type EffectType => typeof(T);
    }
}