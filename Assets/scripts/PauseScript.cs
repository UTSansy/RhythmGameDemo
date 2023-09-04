using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScript : MonoBehaviour {
    // Update is called once per frame
    public GameObject pauseMenu;
    public AudioSource music;
    private bool isPaused = false;
    void Update() {
        if (Input.GetKeyDown(KeyCode.Escape)) {
            if (isPaused) {
                Resume();
            } else {
                Pause();
            }
        }
    }

    public void Resume( ) {
        Time.timeScale = 1f;
        music.Play();
        pauseMenu.SetActive(false);
        isPaused = false;
    }

    public void Pause( ) {
        Time.timeScale = 0f;
        music.Pause();
        pauseMenu.SetActive(true);
        isPaused = true;
    }
}

