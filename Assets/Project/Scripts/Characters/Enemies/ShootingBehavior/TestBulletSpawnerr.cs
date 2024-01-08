using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Content;
using UnityEngine;

public class TestBulletSpawnerr : MonoBehaviour {
    public enum SpawnerType { Straight, Spin }
    public enum FireType { StraightFire, CircleFire, SpreadFire }

    [Header("Bullet Attributes")]
    public GameObject bullet;
    public float speed = 5f;
    public float speenSpeed = 1f;
    private int numberOfBullets = 4;

    public SpawnerType spawnerType;
    public FireType fireTipe;
    [SerializeField] private float firingRate = 0.1f;

    private GameObject spawnedBullet;
    private GameBound gameBound;
    private float timer = 0f;

    public int NumberOfBullet { set { numberOfBullets = value; } }
    public float FiringRate { set {
            if (value < 0.1f) {
                value = 0.1f;
            } else {
                firingRate = value;
            } 
        } 
    }

    private void Start() {
        gameBound = FindAnyObjectByType<GameBound>();
    }
    private void Update() {
        if (IsInGameField(transform.position)) {
            timer += Time.deltaTime;
            if (spawnerType == SpawnerType.Spin) {
                transform.eulerAngles = new Vector3(0f, 0f, transform.eulerAngles.z + speenSpeed);
            }
            if (timer >= firingRate) {
                switch (fireTipe) {
                    case FireType.StraightFire:
                        StraightShot();
                        break;
                    case FireType.CircleFire:
                        CircleShot();
                        break;
                    case FireType.SpreadFire:
                        SpreadShot();
                        break;
                }
                timer = 0f;
            }
        }
    }
    private void StraightShot() {
            spawnedBullet = Instantiate(bullet, transform.position, Quaternion.identity);
            spawnedBullet.GetComponent<TestBullet>().speed = speed;
            spawnedBullet.transform.rotation = transform.rotation;
    }

    private void CircleShot() {
        if (bullet) {
            float angleStep = 360f / numberOfBullets;
            for (int i = 0; i < numberOfBullets; i++) {
                float angle = i * angleStep;
                float weaponRotation = transform.eulerAngles.z;
                float finalAngle = weaponRotation + angle;
                spawnedBullet = Instantiate(bullet, transform.position, Quaternion.Euler(0f, 0f, finalAngle));
                TestBullet testBulletScript = spawnedBullet.GetComponent<TestBullet>();
                if (testBulletScript != null) {
                    testBulletScript.speed = speed;
                }
            }
        }
    }
    private void SpreadShot() {
        if (bullet) { 
            float spreadAngle = 30f; 
            for (int i = 0; i < numberOfBullets; i++) {
                float angle = transform.rotation.eulerAngles.z - (spreadAngle / 2) + (i * (spreadAngle / (numberOfBullets - 1)));
                spawnedBullet = Instantiate(bullet, transform.position, Quaternion.identity);
                spawnedBullet.GetComponent<TestBullet>().speed = speed;
                spawnedBullet.transform.rotation = Quaternion.Euler(0f, 0f, angle);
            }
        }
    }

    bool IsInGameField(Vector3 position) {

        return position.x > gameBound.GameAreaMinX && position.x < gameBound.GameAreaMaxX && position.y > gameBound.GameAreaMinY && position.y < gameBound.GameAreaMaxY;

    }
}