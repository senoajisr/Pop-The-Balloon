using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnClick : MonoBehaviour
{
    public bool playClickAudio = true;
    public RandomAudio randomAudio;
    public AudioSource audioSource;
    public GameObject[] explosionParticles;

    private bool hasBeenClicked = false;

    void Start()
    {

    }

    public void OnClick()
    {
        if (hasBeenClicked) return;
        hasBeenClicked = true;

        Explode();

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

    void Explode ()
    {
        int theChosenOne = Random.Range(0, explosionParticles.Length-1);
        Instantiate(explosionParticles[theChosenOne], transform.position, explosionParticles[theChosenOne].transform.rotation);
    }
}
