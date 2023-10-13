namespace Runner.Core
{
    // Effect for changing the movement type of a character
    public class MoveTypeChangeEffect: BaseEffect<MoveTypeChangeEffectSettings>
    {
        public MoveTypeChangeEffect(MoveTypeChangeEffectSettings settings, ITime time) : 
            base(settings, time)
        {
        }
        
        // Overrides ApplyEffect to change the movement type of the character
        public override void ApplyEffect(IEffectable effectable)
        {
            effectable.MoveType = Settings.MoveType;
        }
    }
}