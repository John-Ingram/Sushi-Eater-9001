using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Press_Button : MonoBehaviour {
    public Sprite bPressed, bLoose;
    public float timePressed = 1;

    public GameObject sushi;
    public GameObject spawner;
    void OnCollisionEnter2D(Collision2D collided)
    {
        this.GetComponent<SpriteRenderer>().sprite = bPressed;
        StartCoroutine(Unpress());
        GameObject clone;
        clone = Instantiate(sushi, spawner.transform.position, spawner.transform.rotation);
        clone.SetActive(true);

    }
    IEnumerator Unpress()
    {
        yield return new WaitForSeconds(timePressed);
        this.GetComponent<SpriteRenderer>().sprite = bLoose;
    }
   
}
