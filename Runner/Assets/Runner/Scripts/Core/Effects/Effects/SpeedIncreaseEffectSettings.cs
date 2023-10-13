using UnityEngine;

namespace Runner.Core
{
    [CreateAssetMenu(fileName = "SpeedIncrease", menuName = "Configs/Effects/SpeedIncrease")]
    public class SpeedIncreaseEffectSettings : BaseEffectSettings<SpeedIncreaseEffect>
    {
        [field: SerializeField]
        public float SpeedIncreaseAmount { get; private set; }
    }
}