using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager
{
    public event Action OnHit;

    private GameControls gameControls;

    public InputManager()
    {
        gameControls = new();
        gameControls.Enable();
        gameControls.Player.Hit.performed += Hit_performed;
    }

    private void Hit_performed(InputAction.CallbackContext obj)
    {
        OnHit?.Invoke();
    }
}
