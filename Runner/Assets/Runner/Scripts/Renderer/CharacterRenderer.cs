using Runner.Core;
using UnityEngine;
using Zenject;

namespace Runner.Renderer
{
    // Renders character animations and updates position every tick
    public class CharacterRenderer: MonoBehaviour, ITickable
    {
        [SerializeField] private Animator _animator;
        
        private const string MoveTypeName = "MoveType";  // Animation parameter name
        private int MoveTypeId { get; } = Animator.StringToHash(MoveTypeName);  // Hashed parameter ID
        
        [Inject]
        private ICharacter _character;  // Injected character interface

        // Called every tick to update animations and position
        void ITickable.Tick()
        {
            UpdateAnimation();
            UpdatePosition();

            // Updates character position based on speed
            void UpdatePosition()
            {
                Vector3 pos = transform.position;
                pos.z += Time.deltaTime * _character.Speed;
                transform.position = pos;
            }

            // Updates animation based on movement type
            void UpdateAnimation()
            {
                int characterMoveType = (int)_character.MoveType;
                Vector3 pos = transform.position;
                pos.y = characterMoveType + 1;
                transform.position = pos;
                // if (_animator.GetInteger(MoveTypeId) != characterMoveType)
                // {
                //     _animator.SetInteger(MoveTypeId, characterMoveType);
                // }
            }
        }
    }
}