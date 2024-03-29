using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class SpawnerTestStage : MonoBehaviour {

    public static SpawnerTestStage Instance { get; private set; }
    public Action OnEndSpawn;


    private void Awake() {
        Instance = this;
    }

    private void Start() {
        FunctionTimer.Create(Wave_1, 2f);
        FunctionTimer.Create(Wave_2, 9f);
        FunctionTimer.Create(Wave_3, 14f);
        FunctionTimer.Create(Wave_4, 19f);
        FunctionTimer.Create(Wave_5, 24f);
        FunctionTimer.Create(Wave_6, 30f);
        FunctionTimer.Create(EndSpawn, 35f);
    }

    private void Wave_1() {
        Debug.Log("Wave_1");
        EnemyCreator.EnemySimpleCreate(new List<Vector3> { PathPoints.mainPoints[1], new Vector3(-4.19f, 2.1f, 0), PathPoints.mainPoints[19] }, 5f, new MovementPointToPoint(2f));
        EnemyCreator.EnemySimpleCreate(new List<Vector3> { PathPoints.mainPoints[3], new Vector3(0.21f, 2.1f, 0), PathPoints.mainPoints[14] }, 5f, new MovementPointToPoint(2f));
        EnemyCreator.EnemySimpleStrenghtCreate(new List<Vector3> { PathPoints.mainPoints[2], PathPoints.mainPoints[20], PathPoints.mainPoints[7] }, 4f, new MovementPointToPoint(3f));
        //Test
        //EnemySimpleCreator.EnemySimpleStrenghtCreate(new List<Vector3> { PathPoints.mainPoints[2], PathPoints.mainPoints[20] }, 4f, new MovementToPoint());
    }

    private async void Wave_2() {
        Debug.Log("Wave_2");
        for (int i = 10; i > 0; i--) {
            EnemyCreator.EnemySimpleCreate(new List<Vector3> { PathPoints.mainPoints[15], PathPoints.mainPoints[2], PathPoints.mainPoints[20], PathPoints.mainPoints[12]}, 3f, new MovementCurve());
            await Task.Delay(200);
        }
    }

    private async void Wave_3() {
        Debug.Log("Wave_3");
        for (int i = 10; i > 0; i--) {
            EnemyCreator.EnemySimpleCreate(new List<Vector3> { PathPoints.mainPoints[10], PathPoints.mainPoints[2], PathPoints.mainPoints[20], PathPoints.mainPoints[17] }, 3f, new MovementCurve());
            await Task.Delay(200);
        }
    }

    private async void Wave_4() {
        Debug.Log("Wave_4");
        for (int i = 10; i > 0; i--) {
            EnemyCreator.EnemySimpleCreate(new List<Vector3> { PathPoints.mainPoints[15], PathPoints.mainPoints[2], PathPoints.mainPoints[20], PathPoints.mainPoints[12] }, 5f, new MovementCurve());
            EnemyCreator.EnemySimpleCreate(new List<Vector3> { PathPoints.mainPoints[10], PathPoints.mainPoints[2], PathPoints.mainPoints[20], PathPoints.mainPoints[17] }, 5f, new MovementCurve());
            await Task.Delay(200);
        }
    }

    private void Wave_5() {
        Debug.Log("Wave_5");
        EnemyCreator.EnemySimpleCreate(new List<Vector3> { PathPoints.mainPoints[15], PathPoints.mainPoints[11] }, 5f, new MovementToPoint());
        EnemyCreator.EnemySimpleStrenghtCreate(new List<Vector3> { PathPoints.mainPoints[16], PathPoints.mainPoints[20], PathPoints.mainPoints[12] }, 5f, new MovementPointToPoint(2f));
        EnemyCreator.EnemySimpleCreate(new List<Vector3> { PathPoints.mainPoints[17], PathPoints.mainPoints[13] }, 5f, new MovementToPoint());
    }

    private void Wave_6() {
        Debug.Log("Wave_6");
        EnemyCreator.EnemySimpleCreate(new List<Vector3> { PathPoints.mainPoints[10], PathPoints.mainPoints[16] }, 5f, new MovementToPoint());
        EnemyCreator.EnemySimpleStrenghtCreate(new List<Vector3> { PathPoints.mainPoints[11], PathPoints.mainPoints[20], PathPoints.mainPoints[17] }, 5f, new MovementPointToPoint(2f));
        EnemyCreator.EnemySimpleCreate(new List<Vector3> { PathPoints.mainPoints[12], PathPoints.mainPoints[18] }, 5f, new MovementToPoint());
    }

    private void EndSpawn() {
        OnEndSpawn?.Invoke();
    }
}