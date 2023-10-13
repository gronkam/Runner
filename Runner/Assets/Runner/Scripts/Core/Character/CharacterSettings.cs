using UnityEngine;

namespace Runner.Core
{
    [CreateAssetMenu(fileName = "CharacterSettings", menuName = "Configs/Character Settings")]
    // ScriptableObject for configuring default character settings
    public class CharacterSettings: ScriptableObject
    {
        [field: SerializeField]
        public float DefaultSpeed { get; private set; }
        
        [field: SerializeField]
        public MoveType DefaultMoveType { get; private set; }
    }
}