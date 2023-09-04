using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreController : MonoBehaviour {
    private ScoreManager scoreManager;
    private TextMeshProUGUI scoreText;
    void Start() {
        scoreManager = FindAnyObjectByType<ScoreManager>();
        scoreText = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update() {
            scoreText.text = "Score: " + scoreManager.score;
    }
}
