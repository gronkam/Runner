using UnityEngine;

namespace Runner.Core
{
    [CreateAssetMenu(fileName = "SpeedMultiplier", menuName = "Configs/Effects/SpeedMultiplier")]
    // Settings for applying a speed multiplier effect
    public class SpeedMultiplierEffectSettings : BaseEffectSettings<SpeedMultiplierEffect>
    {
        [field: SerializeField]
        public float SpeedMultiplier { get; private set; }
    }
}