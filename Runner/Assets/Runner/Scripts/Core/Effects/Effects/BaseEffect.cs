namespace Runner.Core
{
    // Abstract class for creating effects, to be inherited by specific effect classes
    public abstract class BaseEffect
    {
        // Indicates whether the effect has expired
        public bool IsExpired { get; private set; }
        
        // The progress of the effect over its duration
        public float Progress { get; private set; }
        
        // The time at which the effect started
        public float StartTime { get; }
        
        // Abstract property for the duration of the effect, to be overridden by subclasses
        public abstract float Duration { get; }

        // Interface instance to access current time
        private ITime _time;
        
        protected BaseEffect(ITime time)
        {
            _time = time;
            StartTime = time.CurrentTime;
            IsExpired = false;
        }

        // Method to update the progress and expired status of the effect
        public void RefreshEffect()
        {
            Progress = (_time.CurrentTime - StartTime) / Duration;
            IsExpired = Progress >= 1;
        }
        
        // Abstract method to apply the effect to a effectable, to be overridden by subclasses
        public abstract void ApplyEffect(IEffectable effectable);
    }

    // Generic abstract class for effects, extending BaseEffect
    public abstract class BaseEffect<T>: BaseEffect where T: BaseEffectSettings
    {
        // The settings object for this effect
        protected T Settings { get; }

        public override float Duration => Settings.Duration;

        protected BaseEffect(T settings, ITime time): base(time)
        {
            Settings = settings;
        }
    }
}