namespace Runner.Core
{
    public abstract class BaseEffect
    {
        public bool IsExpired { get; private set; }
        public float Progress { get; private set; }
        public float StartTime { get; }
        public abstract float Duration { get; }

        private ITime _time;
        
        protected BaseEffect(ITime time)
        {
            _time = time;
            StartTime = time.CurrentTime;
            IsExpired = false;
        }

        public void RefreshEffect()
        {
            Progress = (_time.CurrentTime - StartTime) / Duration;
            IsExpired = Progress >= 1;
        }
        
        public abstract void ApplyEffect(IEffectable character);
    }

    public abstract class BaseEffect<T>: BaseEffect where T: BaseEffectSettings
    {
        protected T Settings { get; }

        public override float Duration => Settings.Duration;

        protected BaseEffect(T settings, ITime time): base(time)
        {
            Settings = settings;
        }
    }
}