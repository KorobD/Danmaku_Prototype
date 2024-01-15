using UnityEngine;

public class PlayerDefaultProjectile : MonoBehaviour, IPlayerProjectile {

    private float destroyPosition = 5f;

    private void Update() {
        if (transform.position.y > destroyPosition) {
            DestroyObject();
        }
    }

    private void DestroyObject() {
        Destroy(gameObject);
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        Destroy(gameObject);
    }
}
