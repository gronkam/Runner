namespace Runner.Core
{
    public class SpeedMultiplierEffect: BaseEffect<SpeedMultiplierEffectSettings>
    {
        public SpeedMultiplierEffect(SpeedMultiplierEffectSettings settings, ITime time) : 
            base(settings, time)
        {
        }

        public override void ApplyEffect(IEffectable effectable)
        {
            effectable.Speed *= Settings.SpeedMultiplier;
        }
    }
}