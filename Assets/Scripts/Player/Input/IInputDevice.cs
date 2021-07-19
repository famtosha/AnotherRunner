public interface IInputDevice
{
    float leftRightDelta { get; }
    bool isJump { get; }
    void UpdateInput();
}
