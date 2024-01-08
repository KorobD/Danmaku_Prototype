using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementCurve : IMovementBehavior {

    private float tParam = 0f;
    private float duration;

    public Vector3 Move(Vector3 currentPosition, List<Vector3> waypoints, float speedMove) {
        if (duration == 0f) {
        duration = Vector2.Distance(waypoints[0], waypoints[1]) / speedMove;
        }
        if (tParam <= 1f) {
            currentPosition = BezierCurve.GetPoint(waypoints[0], waypoints[1], waypoints[2], waypoints[3], tParam);
            tParam += Time.deltaTime / duration;
        }
        return currentPosition;
    }
}
