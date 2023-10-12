using Runner.Core;
using UnityEngine;
using Zenject;

namespace Runner.Renderer
{
    public class CharacterRenderer: MonoBehaviour, ITickable
    {
        [SerializeField] private Animator _animator;
        
        private const string MoveTypeName = "MoveType";
        private int MoveTypeId { get; } = Animator.StringToHash(MoveTypeName);
        
        [Inject]
        private ICharacter _character;

        void ITickable.Tick()
        {
            UpdateAnimation();
            UpdatePosition();

            void UpdatePosition()
            {
                Vector3 pos = transform.position;
                pos.z += Time.deltaTime * _character.Speed;
                transform.position = pos;
            }

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