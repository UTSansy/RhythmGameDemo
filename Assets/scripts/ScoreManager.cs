using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreManager : MonoBehaviour {
    // Start is called before the first frame update
    public int score = 0;
    public void addScore(int points) {
        score += points;
    }

    private void Update( ) {
        // Debug.Log("score is: " + score);
    }
}
