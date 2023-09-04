using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class  SongsManager : MonoBehaviour {
    public List<AudioSource> audioList = new List<AudioSource>();
    private void Start() {
        DontDestroyOnLoad(gameObject);

        int max = audioList.Count();
        for (int i = 0; i < max; i++) {
            audioList[i].Play();
            audioList[i].Stop();
        }
    }

    public AudioSource ReturnSong(int index) {
        return audioList[index];
    }

    public int Count() {
        return audioList.Count(); ;
    }

    public void Play(int index) {
        audioList[index].Play();
    }

    public void Stop(int index) {
        audioList[index].Stop();
    }
}
