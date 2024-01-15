using UnityEngine;

public class TestBullet : MonoBehaviour, IEnemyProjectile {

    public float rotation = 0f;
    public float speed = 1f;

    private Vector2 spawnPoint;
    private float timer = 0f;


    private GameBound gameBound;

    void Start() {
        gameBound = FindAnyObjectByType<GameBound>();
        spawnPoint = new Vector2(transform.position.x, transform.position.y);
    }


    void Update() {
        if (IsNotInGameField(transform.position)) {
            Destroy(this.gameObject);
        } 
        
        timer += Time.deltaTime;
        transform.position = Movement(timer);
    }

    private Vector2 Movement(float timer) {
        float x = timer * speed * transform.right.x;
        float y = timer * speed * transform.right.y;
        return new Vector2(x + spawnPoint.x, y + spawnPoint.y);
    }

    bool IsNotInGameField(Vector3 position) {

        return position.x < gameBound.GameAreaMinX - 10f || position.x > gameBound.GameAreaMaxX + 10f || position.y < gameBound.GameAreaMinY - 10f || position.y > gameBound.GameAreaMaxY + 10f;

    }
}
