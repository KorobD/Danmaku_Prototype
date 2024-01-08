using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShootingBehaviour : MonoBehaviour {


    private bool inArea = false;
    private GameObject prefabProjectile;
    private GameBound gameBound;

    private void Start() {
        gameBound = FindAnyObjectByType<GameBound>();
    }
    public void Update() {
        if (IsInGameField(transform.position)) {

        }
    }

    bool IsInGameField(Vector3 position) {

        return position.x > gameBound.GameAreaMinX && position.x < gameBound.GameAreaMaxX && position.y > gameBound.GameAreaMinY && position.y < gameBound.GameAreaMaxY;

    }

    public void Construct() {



    }

}
