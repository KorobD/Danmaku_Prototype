using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IMovementBehavior {
    public Vector3 Move(Vector3 currentPosition, List<Vector3> waypoints, float speedMove);
}
