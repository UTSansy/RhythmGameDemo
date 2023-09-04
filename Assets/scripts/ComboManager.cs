using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ComboManager : MonoBehaviour {
    public int combo = 0;
    private TextMeshProUGUI comboText;

    private void Start( ) {
        comboText = GetComponent<TextMeshProUGUI>();
    }
    public void onHit(int hitType) {
        if (hitType == 0) {
            combo = 0;
        } else {
            combo++;
        }

        comboText.text = "Combo: " + combo;
    }
}
