using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chopstickthrow : MonoBehaviour {
    public GameObject targetObj;
    public float speed = 1;
    public AudioSource audioSource;
    public AudioClip soundEffect;

    private bool hasCollided = false;
    private bool hasPlayed = false;

    private void OnCollisionEnter2D(Collision2D thing)
    {
        if (thing.gameObject.tag == "Sushi")
        {
            hasCollided = true;
            Destroy(gameObject);
        }
    }


    void Update () {
        if (!hasCollided)
        {
            Vector2 target = targetObj.transform.position;
            gameObject.transform.position = Vector2.MoveTowards(gameObject.transform.position, target, speed / 100);
        }
        if (gameObject.activeSelf)
        {
            if (!audioSource.isPlaying)
            {
                if (!hasPlayed)
                {
                    audioSource.clip = soundEffect;
                    audioSource.Play();
                    hasPlayed = true;
                }
            }

        }

    }
}
