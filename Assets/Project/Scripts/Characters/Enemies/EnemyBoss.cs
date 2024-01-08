using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBoss : MonoBehaviour, IEnemy {
    
    private int healthPoints;
    private int battleStage;
    
    public int HealthPoint {
        set {
            if (0 < value) {
                healthPoints = value;
            } else {
                Debug.Log("Invalid value: \"healtPoint\", the value will be set to default: 5");
                healthPoints = 5;
            }
        }
    }
    public int BattleStage {
        set {
            if (0 < value) {
                battleStage = value;
            } else {
                Debug.Log("Invalid value: \"battleStage\", the value will be set to default: 1");
                battleStage = 1;
            }
        }
    }

    public void TakeDamage(int damage) {
        healthPoints -= damage;
    }

    public void GiveBonus(string bonus) {
        
    }
}
