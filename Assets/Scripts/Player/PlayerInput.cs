using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public float leftRightDelta => _inputDevice.leftRightDelta;
    public bool isJump => _inputDevice.isJump;

    private IInputDevice _inputDevice;

    private void Start()
    {
        switch (Application.platform)
        {
            case RuntimePlatform.WindowsEditor:
                _inputDevice = new PCInputDevice();
                break;

            case RuntimePlatform.Android:
                _inputDevice = new PhoneInputDevice();
                break;

            case RuntimePlatform.IPhonePlayer:
                _inputDevice = new PhoneInputDevice();
                break;

        }
    }

    private void Update()
    {
        _inputDevice.UpdateInput();
    }
}