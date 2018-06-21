using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Press_Button : MonoBehaviour {
    public Sprite bPressed, bLoose;
    public float timePressed = 1;
    public float gameSpeed = 1;
    public GameObject sushi;
    public GameObject spawner;


    //################Time Stuff####################
    void SpeedUp()
    {
        gameSpeed += 0.01f;
        Time.timeScale = gameSpeed;
        Time.fixedDeltaTime = Time.timeScale * 0.02f;
    }

    //################Button Stuff##################
    void OnCollisionEnter2D(Collision2D collided)
    {
        
        this.GetComponent<SpriteRenderer>().sprite = bPressed;
        StartCoroutine(Unpress());
        GameObject clone;
        clone = Instantiate(sushi, spawner.transform.position, spawner.transform.rotation);
        clone.SetActive(true);
        UpdateScore();

    }
    IEnumerator Unpress()
    {
        yield return new WaitForSeconds(timePressed);
        this.GetComponent<SpriteRenderer>().sprite = bLoose;
    }

    void UpdateScore()
    {
        SpeedUp();
    }
}
