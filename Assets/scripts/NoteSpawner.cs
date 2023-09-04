using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteSpawner : MonoBehaviour {
    public float[] notes;

    public string key;
    public GameObject notePrefab;
    public AudioSource song;
    public float fallSpeed = 1f;
    private int nextNoteIndex = 0;
    private int index;
    private SongsManager songsManager;

    private void Start() {
        songsManager = FindAnyObjectByType<SongsManager>(); 
        index = PlayerPrefs.GetInt("index", 0);
        songsManager.Play(index);
    }
    void Update() {
        if (nextNoteIndex < notes.Length && song.time >= notes[nextNoteIndex]) {
            GameObject note = Instantiate(notePrefab, transform.position, Quaternion.identity);
            note.GetComponent<Rigidbody2D>().velocity = new Vector2(0f, -fallSpeed);
            nextNoteIndex++;
        }
    }
}