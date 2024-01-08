using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class GameInput : MonoBehaviour {

    private GameInputActions gameInputActions;

    private void Awake() {

        gameInputActions = new GameInputActions();
        

    }
    private void OnEnable() {
        gameInputActions.Player.Enable();
    }

    private void OnDisable() {
        gameInputActions.Player.Disable();
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
}
