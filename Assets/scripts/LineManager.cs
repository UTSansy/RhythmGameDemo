using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// using UnityEngine.InputSystem.Interactions;

public class LineManager : MonoBehaviour {
    public List<NoteDetect> detectionAreas;
    public MissDetect missDetect;
    public KeyCode keyToPress;
    public List<GameObject> currentNotes = new List<GameObject>();
    private NoteManager noteManager;

    public void Start() {
        noteManager = FindAnyObjectByType<NoteManager>();
    }
  
    public void NoteEntered(GameObject note) {
        currentNotes.Insert(0, note);
    }

    public void NoteExited(GameObject note) {
        Debug.Log("List has? " + currentNotes.Contains(note));
        currentNotes.Remove(note);
    }
    public void addScore(int num) {
        noteManager.addScore(num);
    }

    public void addCombo(int num) {
        noteManager.addCombo(num);
    }

    void Update() {
        int count = currentNotes.Count;

        if (Input.GetKeyDown(keyToPress) && count > 0) {
            Debug.Log(keyToPress);
            GameObject note = currentNotes[count - 1];
            if (note == null) {
                Debug.Log(count);
            }

            foreach (NoteDetect area in detectionAreas) {
                if (area.hasNote(note)) {
                    area.ProcessNote(note);
                    NoteExited(note);
                    Destroy(note);
                }
            }
        }
    }
}