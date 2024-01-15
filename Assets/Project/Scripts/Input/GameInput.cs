using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

public class GameInput : MonoBehaviour {

    public static GameInput Instance { get; private set; } 


    private GameInputActions gameInputActions;

    public Action OnPauseAction;


    private void Awake() {
        Instance = this;
        gameInputActions = new GameInputActions();

        gameInputActions.Player.Enable();
        gameInputActions.Player.Pause.performed += Pause_performed;
    }

    private void OnDestroy() {
        gameInputActions.Player.Pause.performed -= Pause_performed;
        gameInputActions.Dispose();
    }

    public Vector2 GetMovementVectorNormalized() {
        Vector2 inputVector = gameInputActions.Player.Move.ReadValue<Vector2>();
        inputVector = inputVector.normalized;
        return inputVector;
    }

    public bool OnShooting() {
        bool isShooting = gameInputActions.Player.Shoot.ReadValue<float>() > 0.1f;
        return isShooting;
    }

    public bool OnSlowMove() {
        bool isSlowMove = gameInputActions.Player.SlowMove.ReadValue<float>() > 0.1f;
        return isSlowMove;
    }

    private void Pause_performed(InputAction.CallbackContext context) {
        OnPauseAction?.Invoke();
    }
}
