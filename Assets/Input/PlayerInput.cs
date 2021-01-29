using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInput : MonoBehaviour
{

    PlayerInputActions _playerInputActions;

    [HideInInspector]
    public bool _player1Pulse = false;

    [HideInInspector]
    public bool _player2Pulse = false;

    [HideInInspector]
    public Vector2 _movementInputP1 = new Vector2();

    [HideInInspector]
    public Vector2 _movementInputP2 = new Vector2();

    [HideInInspector]
    public bool _powerUpEnabled;

    private void Awake()
    {
        if (_playerInputActions == null)
            _playerInputActions = new PlayerInputActions();
    }


    private void OnEnable()
    {
        _playerInputActions.Enable();
        _playerInputActions.Player1Actions.Pulse.performed += EnablePulse1;
        _playerInputActions.Player1Actions.Pulse.canceled += DisablePulse1;

        _playerInputActions.Player2Actions.Pulse.performed += EnablePulse2;
        _playerInputActions.Player2Actions.Pulse.canceled += DisablePulse2;

        _playerInputActions.PlayerMovement.Player1Move.performed += Player1_Move_Performed;
        _playerInputActions.PlayerMovement.Player1Move.canceled += Player1_Move_Canceled;

        _playerInputActions.PlayerMovement.Player2Move.performed += Player2_Move_Performed;
        _playerInputActions.PlayerMovement.Player2Move.canceled += Player2_Move_Canceled;

        _playerInputActions.Player1Actions.PowerUp.performed += Enable_PowerUp;
    }

    private void OnDisable()
    {
        _playerInputActions.Disable();
        _playerInputActions.Player1Actions.Pulse.performed -= EnablePulse1;
        _playerInputActions.Player1Actions.Pulse.canceled -= DisablePulse1;

        _playerInputActions.Player2Actions.Pulse.performed -= EnablePulse2;
        _playerInputActions.Player2Actions.Pulse.canceled -= DisablePulse2;

        _playerInputActions.PlayerMovement.Player1Move.performed -= Player1_Move_Performed;
        _playerInputActions.PlayerMovement.Player1Move.canceled -= Player1_Move_Canceled;

        _playerInputActions.PlayerMovement.Player2Move.performed -= Player2_Move_Performed;
        _playerInputActions.PlayerMovement.Player2Move.canceled -= Player2_Move_Canceled;

        _playerInputActions.Player1Actions.PowerUp.performed -= Enable_PowerUp;
    }

    private void EnablePulse1(InputAction.CallbackContext context)
    {
        _player1Pulse = true;
    }

    private void DisablePulse1(InputAction.CallbackContext context)
    {
        _player1Pulse = false;
    }

    private void EnablePulse2(InputAction.CallbackContext context)
    {
        _player2Pulse = true;
    }

    private void DisablePulse2(InputAction.CallbackContext context)
    {
        _player2Pulse = false;
    }

    private void Player1_Move_Performed(InputAction.CallbackContext context)
    {
        _movementInputP1 = context.ReadValue<Vector2>();
    }

    private void Player1_Move_Canceled(InputAction.CallbackContext context)
    {
        _movementInputP1 = Vector2.zero;
    }

    private void Enable_PowerUp(InputAction.CallbackContext context)
    {
        //DE MOMENTO SOLO VALE PARA EL EARTHQUAKE TODO IMPORTANTE!!!
        FindObjectOfType<EarthquakeComponent>().StartEarthquake();
    }

    private void Player2_Move_Performed(InputAction.CallbackContext context)
    {
        _movementInputP2 = context.ReadValue<Vector2>();
    }

    private void Player2_Move_Canceled(InputAction.CallbackContext context)
    {
        _movementInputP2 = Vector2.zero;
    }
}
