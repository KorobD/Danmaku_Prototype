using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementToPoint : IMovementBehavior {

    public Vector3 Move(Vector3 currentPosition, List<Vector3> waypoints, float speedMove) {

        Vector3 newPosition = Vector3.MoveTowards(currentPosition, waypoints[1], speedMove * Time.deltaTime);

        return newPosition;
    }
}
