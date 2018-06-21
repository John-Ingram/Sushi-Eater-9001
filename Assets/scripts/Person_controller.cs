using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Person_controller : MonoBehaviour {
    public Sprite personDone;
    public bool done = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Sushi")
        {
            if (!done)
            {
                Destroy(collision.gameObject);
                done = true;
                gameObject.GetComponent<Animator>().enabled = false;
                this.GetComponent<SpriteRenderer>().sprite = personDone;
            }
        }
    }
}
