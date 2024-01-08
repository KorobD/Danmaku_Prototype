using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollBackground : MonoBehaviour {
    
    public float scrollSpeed = 0.2f;

    private void Update() {
        Vector2 offset = new Vector2(0, Time.time * (scrollSpeed * -1));

        GetComponent<Renderer>().material.mainTextureOffset = offset;
    }

}
