using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sushi_Behavior : MonoBehaviour {
    public Sprite failSushi;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Chopstick")
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = failSushi;
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
