using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInput : MonoBehaviour
{

    PlayerInputActions _playerInputActions;

    [HideInInspector]
    public bool _playerPulse = false;

    [HideInInspector]
    public Vector2 _movementInput = new Vector2();

    private void Awake()
    {
        if (_playerInputActions == null)
            _playerInputActions = new PlayerInputActions();
    }


    private void OnEnable()
    {
        _playerInputActions.Enable();
        _playerInputActions.PlayerActions.Pulse.performed += EnablePulse;
        _playerInputActions.PlayerActions.Pulse.canceled += DisablePulse;

        _playerInputActions.PlayerMovement.Move.performed += Move_Performed;
        _playerInputActions.PlayerMovement.Move.canceled += Move_Canceled;

    }

    private void OnDisable()
    {
        _playerInputActions.Disable();
        _playerInputActions.PlayerActions.Pulse.performed -= EnablePulse;
        _playerInputActions.PlayerActions.Pulse.canceled -= DisablePulse;

        _playerInputActions.PlayerMovement.Move.performed -= Move_Performed;
        _playerInputActions.PlayerMovement.Move.canceled -= Move_Canceled;
    }

    private void EnablePulse(InputAction.CallbackContext context)
    {
        _playerPulse = true;
    }

    private void DisablePulse(InputAction.CallbackContext context)
    {
        _playerPulse = false;
    }

    private void Move_Performed(InputAction.CallbackContext context)
    {
        _movementInput = context.ReadValue<Vector2>();
    }

    private void Move_Canceled(InputAction.CallbackContext context)
    {
        _movementInput = Vector2.zero;
    }

}
