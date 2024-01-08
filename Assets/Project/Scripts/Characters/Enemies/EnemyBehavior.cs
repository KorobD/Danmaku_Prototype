using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour {

    private IMovementBehavior movementBehavior;




    private void Start() {

    }

    private void Update() {
        if (movementBehavior != null) {
            //movementBehavior.Move();
        } else {
            Debug.Log("movementBehavior is null");
        }
    }


    public void Construct(IMovementBehavior movement) {
        
        movementBehavior = movement;


    }


}
