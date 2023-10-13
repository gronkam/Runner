using Zenject;

namespace Runner.Core
{
    // Character model class
    public class Character: IEffectable, ICharacter, ITickable
    {
        public float Speed { get; set; }  // Character's speed
        public MoveType MoveType { get; set; }  // Character's movement type
        
        private CharacterSettings Settings { get; }  // Character settings
        private IEffectContainer EffectContainer { get; }  // Effect container for managing effects

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

        // Method to reset character properties to default values
        private void SetDefaults()
        {
            Speed = Settings.DefaultSpeed;
            MoveType = Settings.DefaultMoveType;
        }
    }
}