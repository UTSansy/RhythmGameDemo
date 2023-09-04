using System.Collections.Generic;
using UnityEngine;

public class NoteDetect : MonoBehaviour {
    public string whichArea;
    public int score;
    public AudioSource perfectClickSound;
    public AudioSource earlyClickSound;
    private LineManager lineManager;
    // private ComboManager comboManager;
    private List<GameObject> currentNotes = new List<GameObject>();


    private void Start() {
        lineManager = GetComponentInParent<LineManager>();
        // comboManager = FindObjectOfType<ComboManager>();
    }

  
    public bool hasNote(GameObject note) {
        foreach (GameObject theNotes in currentNotes) {
            if (note == theNotes) {
                return true;
            }
        }
        return false;
    }

    public void ProcessNote(GameObject note) {
        if (whichArea == "TooEarly") {
            earlyClickSound.Play();
            // comboManager.onHit(0);
            lineManager.addCombo(0);
        } else if (whichArea == "Perfect") {
            perfectClickSound.Play();
            // comboManager.onHit(1);
            lineManager.addCombo(1);
        } else {
            earlyClickSound.Play();
            lineManager.addCombo(1);
        }

        lineManager.addScore(score);
        Debug.Log(whichArea);
    }

    // note进来就看到了
    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.gameObject.CompareTag("Note")) {
            currentNotes.Add(collision.gameObject);

            if (this.CompareTag("TooEarly")) {
                lineManager.NoteEntered(collision.gameObject);
            }
        }
    }

    // note出去
    private void OnTriggerExit2D(Collider2D collision) {
        if (collision.gameObject.CompareTag("Note")) {
            currentNotes.Remove(collision.gameObject);

            if (this.CompareTag("Missing")) {
                lineManager.NoteExited(collision.gameObject);
                Destroy(collision.gameObject);
                lineManager.addCombo(0);
            }
        }
    }
}
