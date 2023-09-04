using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;


public class MissDetect : MonoBehaviour{

    private ComboManager comboManager;
    private LineManager lineManager;
    private void Start( ) {
        comboManager = FindObjectOfType<ComboManager>();
        lineManager = FindObjectOfType<LineManager>();
    }

    private void OnTriggerEnter2D(Collider2D collision){
        if (collision.gameObject.CompareTag("Note")){
            comboManager.onHit(0);
            lineManager.NoteExited(collision.gameObject);
            Destroy(collision.gameObject);
        }
    }
}
