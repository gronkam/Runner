using UnityEngine;

namespace Runner.Core
{
    [CreateAssetMenu(menuName = "Configs/Effects/MoveTypeChange")]
    public class MoveTypeChangeEffectSettings: BaseEffectSettings<MoveTypeChangeEffect>
    {
        [field: SerializeField]
        public MoveType MoveType { get; private set; }
    }
}