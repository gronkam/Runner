namespace Runner.Core
{
    // Interface defining character properties
    public interface ICharacter
    {
        float Speed { get; }
        MoveType MoveType { get; }
    }
}