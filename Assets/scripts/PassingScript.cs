using System.Collections;
using System.Collections.Generic;
using UnityEngine;
     

public class PassingScript : MonoBehaviour {
    public AudioSource audioSource;
    public float[] noteSheet;

    /* 
    private SongSelectionController songSelection;
    public void Start() {
        songSelection = FindAnyObjectByType<SongSelectionController>();
    }  */

    public void SetAudio(AudioSource audio) {
        audioSource = audio;
    }

    public void SetNoteSheet(float[] sheet) {
        noteSheet = sheet;
    }

    public AudioSource ReturnAudio() {
        return audioSource;
    }

    public float[] ReturnNoteSheet() {
        return noteSheet;
    }
}