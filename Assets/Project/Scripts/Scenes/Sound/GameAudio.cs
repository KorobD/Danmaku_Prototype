using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameAudio : MonoBehaviour {


    public static GameAudio Instance;


    public Sound[] musicSounds, sfxSounds;
    public AudioSource musicSource, sfxSource;



    private void Awake() {
        if (Instance == null) {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        } else {
            Destroy(gameObject);
        }
    }

    public void Start() {
        PlayMusic("Theme");
    }

    public void PlayMusic(string name) {
        Sound s = Array.Find(musicSounds, x => x.name == name);
        if (s == null) {
            Debug.Log("Sound Not Found");
        } else {
            musicSource.clip = s.clip;
            musicSource.Play();
        }
    }

    public void PlaySFX(string name) {
        Sound s = Array.Find(sfxSounds, x => x.name == name);
        if (s == null) {
            Debug.Log("Sound Not Found");
        } else {
            sfxSource.PlayOneShot(s.clip);
        }
    }

}
