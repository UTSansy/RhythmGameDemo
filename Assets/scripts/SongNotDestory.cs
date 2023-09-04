using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SongNotDestory : MonoBehaviour {
    [System.Serializable] 
    public class noteInfo {
        public float time;
        public int key;
    };

    public noteInfo[] noteInfos;

    void Start() {
        DontDestroyOnLoad(gameObject);
    }

    public noteInfo[] getNoteInfo() {
        return noteInfos;
    }
}
