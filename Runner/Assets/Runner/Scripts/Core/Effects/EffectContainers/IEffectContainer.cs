namespace Runner.Core
{
    // Interface for containers that manage and apply effects
    public interface IEffectContainer
    {
        // Method to refresh all effects, returning true if any changes occurred
        bool RefreshEffects();
        
        // Method to apply all effects to a given effectable entity
        void ApplyEffects(IEffectable effectable);
        
        // Method to add an effect based on provided settings
        void AddEffect(BaseEffectSettings settings);
    }
}