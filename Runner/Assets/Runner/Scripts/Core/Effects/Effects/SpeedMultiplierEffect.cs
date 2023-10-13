namespace Runner.Core
{
    // Effect for applying a speed multiplier to a character
    public class SpeedMultiplierEffect: BaseEffect<SpeedMultiplierEffectSettings>
    {
        public SpeedMultiplierEffect(SpeedMultiplierEffectSettings settings, ITime time) : 
            base(settings, time)
        {
        }

        // Overrides ApplyEffect to multiply the character's speed
        public override void ApplyEffect(IEffectable effectable)
        {
            effectable.Speed *= Settings.SpeedMultiplier;
        }
    }
}