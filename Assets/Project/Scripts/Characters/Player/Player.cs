using System;
using UnityEngine;

public class Player : MonoBehaviour {

    private int healthPoint = 1;
    [SerializeField] private int damage = 1;
    public static Action OnPlayerDestroy;

    private void Update() {
        if (healthPoint <= 0) {
            Destroy(gameObject);
            OnPlayerDestroy?.Invoke();
        }
    }

    private void OnTriggerEnter2D(Collider2D coll) {

        IEnemyProjectile p = coll.gameObject.GetComponent<IEnemyProjectile>();
        IEnemy e = coll.gameObject.GetComponent<IEnemy>();
        if (p != null || e != null) {
            Debug.Log("Enemy or projectile detected!");
            TakeDamage(damage);
        }
    }

    public void TakeDamage(int damage) {
        healthPoint -= damage;
    }


}
