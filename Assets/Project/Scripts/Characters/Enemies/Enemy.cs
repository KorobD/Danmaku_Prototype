using System;
using UnityEngine;

public class Enemy : MonoBehaviour, IEnemy {

    [SerializeField] private int healthPoints = 10;
    [SerializeField] private int damage = 2;
    public static Action OnEnemyDestroy;

    private void Start() {

    }

    private void Update() {
        if (healthPoints <= 0) {
            Destroy(gameObject);
            OnEnemyDestroy?.Invoke();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        
        IPlayerProjectile p = collision.gameObject.GetComponent<IPlayerProjectile>();
        if (p != null) {
            TakeDamage(damage);
        }
    }

    public void TakeDamage(int damage) {
        healthPoints -= damage;
    }

}
