using System;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.EnhancedTouch;

public class InputManager
{
    public event Action<Vector2> OnHit;

    private GameControls gameControls;

    public InputManager()
    {
        gameControls = new();
        gameControls.Enable();
        gameControls.Player.Hit.performed += Hit_performed;
    }

    private void Hit_performed(InputAction.CallbackContext obj)
    {
        TouchSimulation.Enable();
        Vector2 touchPosition = Touchscreen.current.position.ReadValue();

        Vector2 touchWorldPosition = Camera.main.ScreenToWorldPoint(touchPosition);

        OnHit?.Invoke(touchPosition);
    }

    private void DisableInput()
    {
        gameControls.Disable();
    }

    private void EnableInput()
    {
        gameControls.Enable();
    }
}
