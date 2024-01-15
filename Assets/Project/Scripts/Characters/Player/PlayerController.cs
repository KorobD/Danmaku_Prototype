using System;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    private GameInput gameInput;
    [Space]
    [Header("Movement")]
    [SerializeField, Range(1f, 10f)] private float moveSpeed = 5f;
    private float slowMoveSpeed = 2f;

    //---FuckingVariables----
    private GameBound gameBound;
    private float gameAreaMinX;
    private float gameAreaMaxX;
    private float gameAreaMinY;
    private float gameAreaMaxY;
    //------------------------


    private void Awake() {
        gameBound = FindAnyObjectByType<GameBound>();
        gameInput = FindAnyObjectByType<GameInput>();
    }
    private void Start() {
        gameAreaMinX = gameBound.GameAreaMinX;
        gameAreaMaxX = gameBound.GameAreaMaxX;
        gameAreaMinY = gameBound.GameAreaMinY;
        gameAreaMaxY = gameBound.GameAreaMaxY;

    }

    private void Update() {
        Move();
        ClampedPosition();
    }

    public void Move() {
        SlowMove();
        Vector2 inputVector = gameInput.GetMovementVectorNormalized();
        Vector3 moveDir = new Vector3(inputVector.x, inputVector.y, 0f);
        transform.position += moveDir * moveSpeed * Time.deltaTime;
    }
    private void ClampedPosition() {
        Vector2 clampedPos = transform.position;
        clampedPos.x = Mathf.Clamp(clampedPos.x, gameAreaMinX, gameAreaMaxX);
        clampedPos.y = Mathf.Clamp(clampedPos.y, gameAreaMinY, gameAreaMaxY);
        transform.position = clampedPos;
    }

    private void SlowMove() {
        bool slowMove = gameInput.OnSlowMove();
        if (slowMove) {
            moveSpeed = slowMoveSpeed;
        } else {
            moveSpeed = 5f;
        }
    }

}
