using System.Collections.Generic;
using UnityEngine;

public class EnemyMovementBehaviour : MonoBehaviour {

    public List<Vector3> waypoints = new List<Vector3>();

    private IMovementBehavior movementBehavior;
    private float speedMove;
    private Vector3 currentPosition;


    public float SpeedMove {
        set {
            if (value < 1f || value > 15f) {
                Debug.LogError("value \"speedMove\" out of range (1f - 15f), default value will be set: 5f");
            } else {
                speedMove = value;
            }
        }
    }
    public Vector3 CurrentPosition { set { currentPosition = value; } }

    void Update() {
        currentPosition = transform.position;
        transform.position = movementBehavior.Move(currentPosition, waypoints, speedMove);
        DestroyObject();
    }


    private void DestroyObject() {
        if (Vector3.Distance(transform.position, waypoints[waypoints.Count - 1]) < 0.3f) {
            Destroy(gameObject);
        }
    }

    public void Construct(IMovementBehavior movement) {

        movementBehavior = movement;

    }

}
