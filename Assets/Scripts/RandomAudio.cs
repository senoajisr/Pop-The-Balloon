using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomAudio : MonoBehaviour
{
    public AudioClip[] audioClips;
    public AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void PlayRandomAudio() {
        int theChosenOne = Random.Range(0, audioClips.Length-1);
        audioSource.clip = audioClips[theChosenOne];
        audioSource.Play();
    }
}
