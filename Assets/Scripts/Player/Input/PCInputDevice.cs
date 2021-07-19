using UnityEngine;

public class PCInputDevice : IInputDevice
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
        int centerofScreen = Screen.width / 2;
        int mousePosition = (int)Input.mousePosition.x;

        leftRightDelta = centerofScreen - mousePosition;
        leftRightDelta *= Time.deltaTime;
    }

    private void UpdateJump()
    {
        isJump = Input.GetMouseButtonDown(0);
    }
}
