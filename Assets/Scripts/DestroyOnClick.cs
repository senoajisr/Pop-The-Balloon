using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnClick : MonoBehaviour
{
    public bool playClickAudio = true;
    public RandomAudio randomAudio;
    public AudioSource audioSource;

    private bool hasBeenClicked = false;

    void Start()
    {

    }

    public void OnClick()
    {
        if (hasBeenClicked) return;
        hasBeenClicked = true;

        if (randomAudio != null) {
            randomAudio.PlayRandomAudio();
            StartCoroutine(WaitForAudio());
        } else {
            Destroy(gameObject);
        }
    }

    public IEnumerator WaitForAudio()
    {
        yield return new WaitUntil(() => audioSource.isPlaying == false);
        Destroy(gameObject);
    }
}
