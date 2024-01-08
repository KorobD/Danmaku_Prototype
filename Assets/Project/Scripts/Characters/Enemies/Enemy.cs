using UnityEngine;
using UnityEngine.UIElements;

public class Enemy : MonoBehaviour, IEnemy {



    private int healthPoints;

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


    private void Start() {

    }

   
    public void TakeDamage(int damage) {
        healthPoints -= damage;
    }

    public void GiveBonus(string bonus) {

    }
    
}
