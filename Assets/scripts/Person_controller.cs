using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Person_controller : MonoBehaviour {
    public Sprite personDone;
    public bool done = false;
    public Check_For_Completion complete;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Sushi")
        {
            if (!done)
            {
                Destroy(collision.gameObject);
                done = true;
                complete.PlayerFinished();
                gameObject.GetComponent<Animator>().enabled = false;
                this.GetComponent<SpriteRenderer>().sprite = personDone;
            }
        }
    }
}
