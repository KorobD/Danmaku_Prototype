using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Drawing;
using UnityEngine;


public class MovementPointToPoint : IMovementBehavior {
    
    private int waypointIndex = 1;
    private float timeRemaining;
    public float TimeRemaining {
        set {

            if (value < 0f) {
                Debug.LogError("value \"timeRemaning\" less than 0, default value will be set: 0f");
            } else {
                timeRemaining = value;
            }
        }
    }

    public Vector3 Move(Vector3 currentPosition, List<Vector3> waypoints, float speedMove) {
        if (waypointIndex < waypoints.Count) {

            Vector3 targetPoint = waypoints[waypointIndex];
            currentPosition = Vector3.MoveTowards(currentPosition, targetPoint, speedMove * Time.deltaTime);

            if (Vector3.Distance(currentPosition, targetPoint) < 0.1f) {
                if (timeRemaining > 0f) {
                    timeRemaining -= Time.deltaTime;
                    if (timeRemaining <= 0f) {
                        waypointIndex++;
                    }
                } else {
                    waypointIndex++;
                }
            }

        }
        return currentPosition;
    }
    public MovementPointToPoint(float timeRemaining) {
        this.TimeRemaining = timeRemaining;
    }
}