﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;
using System.Linq;

public class SongSelectionController : MonoBehaviour {
    public ScrollRect scrollRect;
    private int currentSongIndex = 0;
    private float targetScrollPosition;
    public float scrollSpeed = 5f;
    private SongsManager songsManager;
    private int index = 0;
    private int maxSong;

    void Start() {
        songsManager = FindAnyObjectByType<SongsManager>();
        maxSong = songsManager.Count();
        targetScrollPosition = 1f;

        songsManager.Play(index);
    }

    void Update() {
        if (Input.GetKeyDown(KeyCode.DownArrow)) {
            songsManager.Stop(index);
            index = (index + 1) % maxSong;
            songsManager.Play(index);
            
            currentSongIndex = Mathf.Min(currentSongIndex + 1, maxSong - 1);
            targetScrollPosition = 1f - (float)currentSongIndex / (maxSong - 1);

        } else if (Input.GetKeyDown(KeyCode.UpArrow)) {
            songsManager.Stop(index);
            if (index == 0) {
                index = maxSong - 1;
            } else {
                index--;
            }
            songsManager.Play(index);

            currentSongIndex = Mathf.Max(currentSongIndex - 1, 0);
            targetScrollPosition = 1f - (float)currentSongIndex / (maxSong - 1);
        } else if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.KeypadEnter)) {
            LoadSelectedSong();
        }

        scrollRect.verticalNormalizedPosition = Mathf.MoveTowards(scrollRect.verticalNormalizedPosition, 
                                                                                                        targetScrollPosition, 
                                                                                                        scrollSpeed * Time.deltaTime);
    }
    
    void LoadSelectedSong() {
        PlayerPrefs.SetInt("index", index);
        songsManager.Stop(index);
        SceneManager.LoadScene("游玩界面");
    }
}