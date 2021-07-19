using UnityEngine;

public class PhoneInputDevice : IInputDevice
{
    public float leftRightDelta { get; private set; }
    public bool isJump { get; private set; }

    public void UpdateInput()
    {
        UpdateLeftRightDelta();
        UpdateJump();
    }

    private void UpdateLeftRightDelta()
    {
        leftRightDelta = -Input.acceleration.x;
        leftRightDelta *= 1000 * Time.deltaTime;
    }

    private void UpdateJump()
    {
        isJump = Input.touchCount > 0;
    }
}