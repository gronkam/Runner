using UnityEngine;

namespace Runner.Core
{
    [CreateAssetMenu(fileName = "CharacterSettings", menuName = "Configs/Character Settings")]
    public class CharacterSettings: ScriptableObject
    {
        [field: SerializeField]
        public float DefaultSpeed { get; private set; }
        
        [field: SerializeField]
        public MoveType DefaultMoveType { get; private set; }
    }
}