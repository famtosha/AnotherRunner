using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public float leftRightDelta { get; private set; }

    private void Update()
    {
        UpdateInput();
    }

    private void UpdateInput()
    {
        int centerofScreen = Screen.width / 2;
        int mousePosition = (int)Input.mousePosition.x;

        leftRightDelta = centerofScreen - mousePosition;
        leftRightDelta *= Time.deltaTime;
    }
}
