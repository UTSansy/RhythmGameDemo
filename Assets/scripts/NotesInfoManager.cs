using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotesInfoManager : MonoBehaviour {
    public NoteSpawner s1;
    public NoteSpawner s2;
    public NoteSpawner s3;
    public NoteSpawner s4;
    private AudioSource audioInfo;
    private SongsManager songsManager;
    private int index;
    void Start() {
        index = PlayerPrefs.GetInt("index", 0);
        songsManager = FindAnyObjectByType<SongsManager>();
        audioInfo = songsManager.ReturnSong(index);
    }
}
