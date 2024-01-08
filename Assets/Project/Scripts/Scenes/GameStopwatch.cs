using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStopwatch : MonoBehaviour {

    public static Action<int> OnSecondsPassed;

    private int seconds;
    private bool isTimerRunning = false;

    private void Awake() {

    }

    private void Start() {
            StartCoroutine(OneSecTimer());
          
    }
    private IEnumerator OneSecTimer() {
        if (isTimerRunning) {
            yield break;
        }

        isTimerRunning = true;

        while (true) {
            seconds++;
            //Debug.Log(seconds);
            OnSecondsPassed?.Invoke(seconds);
            yield return new WaitForSeconds(1);
        }
    }

}

