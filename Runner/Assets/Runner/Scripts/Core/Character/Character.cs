using Zenject;

namespace Runner.Core
{
    public class Character: IEffectable, ICharacter, ITickable
    {
        public float Speed { get; set; }
        public MoveType MoveType { get; set; }
        
        private CharacterSettings Settings { get; }
        private IEffectContainer EffectContainer { get; }

        public Character(CharacterSettings settings, IEffectContainer effectContainer)
        {
            Settings = settings;
            EffectContainer = effectContainer;
            SetDefaults();
        }
        
        void ITickable.Tick()
        {
            if (EffectContainer.RefreshEffects())
            {
                SetDefaults();
                EffectContainer.ApplyEffects(this);
            }
        }

        private void SetDefaults()
        {
            Speed = Settings.DefaultSpeed;
            MoveType = Settings.DefaultMoveType;
        }
    }
}