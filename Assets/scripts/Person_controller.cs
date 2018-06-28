using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Person_controller : MonoBehaviour {
    public Sprite personDone;
    public bool getsHungry;
    public Check_For_Completion complete;
    public float hungerTime = 3.00f;
    private bool done = false;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Sushi")
        {
            if (!done)
            {
                Destroy(collision.gameObject);
                done = true;
                complete.PlayerFinished();
                complete.UpdateScore();
                gameObject.GetComponent<Animator>().enabled = false;
                this.GetComponent<SpriteRenderer>().sprite = personDone;
                
                if (getsHungry)
                {
                    StartCoroutine(GetHungry());
                }
            }
        }
    }

    IEnumerator GetHungry()
    {
        yield return new WaitForSeconds(hungerTime);
        done = false;
        complete.HungryAgain();
        gameObject.GetComponent<Animator>().enabled = true;
        complete.UpdateScore();
    }
}
