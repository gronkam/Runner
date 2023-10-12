using System.Collections.Generic;
using UnityEngine;

namespace Runner.Core
{
    [CreateAssetMenu(fileName = "EffectList", menuName = "Configs/Effects/Effect List")]
    public class EffectListSettings: ScriptableObject
    {
        [field: SerializeField]
        public List<BaseEffectSettings> Effects { get; private set; }
    }
}