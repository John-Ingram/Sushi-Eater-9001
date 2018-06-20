using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Person_controller : MonoBehaviour {
    public Sprite personDone;
    public bool done = false;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Sushi")
        Destroy(collision.gameObject);
        this.GetComponent<SpriteRenderer>().sprite = personDone;
    }
}
