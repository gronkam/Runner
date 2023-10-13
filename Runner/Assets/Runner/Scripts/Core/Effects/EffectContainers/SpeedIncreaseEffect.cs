namespace Runner.Core
{
    public class SpeedIncreaseEffect : BaseEffect<SpeedIncreaseEffectSettings>
    {
        public SpeedIncreaseEffect(SpeedIncreaseEffectSettings settings, ITime time) : 
            base(settings, time)
        {
        }

        public override void ApplyEffect(IEffectable effectable)
        {
            effectable.Speed += Settings.SpeedIncreaseAmount;
        }
    }
}