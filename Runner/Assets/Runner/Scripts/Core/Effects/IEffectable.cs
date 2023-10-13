namespace Runner.Core
{
    // Interface for entities that can be affected by effects
    public interface IEffectable
    {
        float Speed { get; set; }
        MoveType MoveType { get; set; }
    }
}