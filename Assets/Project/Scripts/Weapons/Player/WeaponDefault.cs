using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponDefault : MonoBehaviour {

    private GameInput gameInput;


    [SerializeField] private Transform defaultFirePoint;
    [SerializeField] private Transform prefabProjectaile;
    [SerializeField] private float projectileSpeed = 15f;
    [SerializeField] private float firePerSecond = 15f;
    private float nextFire = 0f;
    private float fireRate = 1;


    
    private void Awake() {
        gameInput = FindObjectOfType<GameInput>();

    }
    private void Start() {
        fireRate = fireRate / firePerSecond;
    }

    private void Update() {
        Shoot();
    }

    private void Shoot() {
        bool isShooting = gameInput.OnShooting();
        if (isShooting && Time.time > nextFire) {
            nextFire = Time.time + fireRate;
            var projectile = Instantiate(prefabProjectaile, defaultFirePoint.position, defaultFirePoint.rotation);
            projectile.GetComponent<Rigidbody2D>().velocity = defaultFirePoint.up * projectileSpeed;
            GameAudio.Instance.PlaySFX("PewPew");
        }
    }

}
