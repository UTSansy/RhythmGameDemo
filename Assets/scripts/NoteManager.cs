using System.Collections.Generic;
using UnityEngine;

public class NoteManager : MonoBehaviour {
    public List<LineManager> lines;
    private ScoreManager scoreManager;
    private ComboManager comboManager;
    private void Start() {
        scoreManager = FindAnyObjectByType<ScoreManager>();
        comboManager = FindAnyObjectByType<ComboManager>();
    }
    public void addScore(int num) {
        scoreManager.addScore(num);
    }

    public void addCombo(int num) {
        comboManager.onHit(num);
    }
}