namespace Runner.Core
{
    // Interface to abstract time access, allowing for different time implementations
    public interface ITime
    {
        float CurrentTime { get; }
    }
}