using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music_Randomizer : MonoBehaviour {
    public AudioSource audioSource;
    public AudioClip[] clips;
    public float timeBetweenClips;

    private int playedClip;
    private int play;

    private void Start()
    {
        DontDestroyOnLoad(this.gameObject);
        Play();
    }
    void Update () {

        if (!audioSource.isPlaying)
        {

            
            if (playedClip != play)
            {
                StartCoroutine(Pause());
            }
        }
	}
    IEnumerator Pause()
    {
        yield return new WaitForSeconds(timeBetweenClips);
        Play();
    }
    private void Play()
    {
        play = Random.Range(0, clips.Length);
        audioSource.clip = clips[play];
        playedClip = play;
        audioSource.Play();
    }
}
