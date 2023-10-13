using UnityEngine;

namespace Runner.Core
{
    [CreateAssetMenu(fileName = "MoveTypeChange", menuName = "Configs/Effects/MoveTypeChange")]
    // Settings for changing the movement type of the character(fly, etc.)
    public class MoveTypeChangeEffectSettings: BaseEffectSettings<MoveTypeChangeEffect>
    {
        [field: SerializeField]
        public MoveType MoveType { get; private set; }
    }
}