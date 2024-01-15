using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class EnemyCreator {

    public static void EnemySimpleCreate(List<Vector3> waypoints, float speedMove, IMovementBehavior movementBehavior) {

        var prefab = Resources.Load<GameObject>("Prefabs/Enemies/TestStage/enemySimple");
        GameObject enemy = GameObject.Instantiate(prefab, waypoints[0], Quaternion.identity);
        enemy.GetComponent<EnemyMovementBehaviour>().waypoints = waypoints;
        enemy.GetComponent<EnemyMovementBehaviour>().SpeedMove = speedMove;
        enemy.GetComponent<EnemyMovementBehaviour>().CurrentPosition = waypoints[0];
        enemy.GetComponent<EnemyMovementBehaviour>().Construct(movementBehavior);
    }

    public static void EnemySimpleStrenghtCreate(List<Vector3> waypoints, float speedMove, IMovementBehavior movementBehavior) {

        var prefab = Resources.Load<GameObject>("Prefabs/Enemies/TestStage/enemySimpleStrength");
        GameObject enemy = GameObject.Instantiate(prefab, waypoints[0], Quaternion.identity);
        enemy.GetComponent<EnemyMovementBehaviour>().waypoints = waypoints;
        enemy.GetComponent<EnemyMovementBehaviour>().SpeedMove = speedMove;
        enemy.GetComponent<EnemyMovementBehaviour>().CurrentPosition = waypoints[0];
        enemy.GetComponent<EnemyMovementBehaviour>().Construct(movementBehavior);
    }

    public static void EnemyBossCreate() {
        var prefab = Resources.Load<GameObject>("Prefabs/Enemies/TestStage/enemyBoss");
        //....
    }

}
