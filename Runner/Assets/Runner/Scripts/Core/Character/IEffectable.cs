namespace Runner.Core
{
    public interface IEffectable
    {
        float Speed { get; set; }
        MoveType MoveType { get; set; }
    }
}