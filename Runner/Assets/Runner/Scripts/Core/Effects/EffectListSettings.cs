using System.Collections.Generic;
using UnityEngine;

namespace Runner.Core
{
    [CreateAssetMenu(fileName = "EffectList", menuName = "Configs/Effects/Effect List")]
    // ScriptableObject for configuring a list of effects
    public class EffectListSettings: ScriptableObject
    {
        [field: SerializeField]
        public List<BaseEffectSettings> Effects { get; private set; }
    }
}