namespace Runner.Core
{
    public interface IEffectContainer
    {
        bool RefreshEffects();
        
        void ApplyEffects(IEffectable effectable);
        
        void AddEffect(BaseEffectSettings settings);
    }
}