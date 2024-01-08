using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDefaultProjectile : MonoBehaviour {

    private float destroyPosition = 5f;

    private void Update() {
        if (transform.position.y > destroyPosition) {
            DestroyObject();
        }
    }

    private void DestroyObject() {
        Destroy(gameObject);
    }
}
