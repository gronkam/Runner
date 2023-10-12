namespace Runner.Core
{
    public class MoveTypeChangeEffect: BaseEffect<MoveTypeChangeEffectSettings>
    {
        public MoveTypeChangeEffect(MoveTypeChangeEffectSettings settings, ITime time) : 
            base(settings, time)
        {
        }
        
        public override void ApplyEffect(IEffectable effectable)
        {
            effectable.MoveType = Settings.MoveType;
        }
    }
}